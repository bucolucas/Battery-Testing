using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    internal class Charger
    {
        public List<BMS> BMSs { get; } = new List<BMS>(8);
        public ChargeRelay ChargeRelay { get; }
        public bool AreAllBMSsFinishedCharging => BMSs.All(x => x.MilliAmps == 0) && ChargeRelay.State == RelayState.Closed;
        public bool AreAnyBMSsDischarging => BMSs.Any(x => x.IsDischarging);

        public IEnumerable<BMS> FinishedDischargingBMSs => BMSs.Where(x => x.IsDischargingFinished);

        public Charger(ICommandChain chain, int bmsCount)
        {
            for (int i = 0; i < bmsCount; i++)
            {
                BMSs.Add(new BMS(i, chain));
            }
            ChargeRelay = new ChargeRelay(chain);
        }

        public async Task BeginCharging()
        {
            await ChargeRelay.BeginCharge(BMSs.Select(b => b.DischargeRelay));
        }

        public async Task Update(bool beginDischargeWhenChargingComplete = true)
        {
            foreach (var bms in BMSs)
            {
                await bms.Update();

                if (bms.IsDischargingFinished && bms.MilliAmps == 0)
                {
                    await bms.DischargeRelay.EndDischarge();
                }
            }

            if (beginDischargeWhenChargingComplete 
                && AreAllBMSsFinishedCharging
                && !AreAnyBMSsDischarging)
            {
                await Task.WhenAll(BMSs.Where(x => x.IsDischargingFinished == false).Select(x => x.DischargeRelay.BeginDischarge(ChargeRelay)));
            }
        }
    }

    internal class CommandConstants
    {
        public const string GET_BMS_STATUS_COMMAND = "bms_status";

        public const string BEGIN_CHARGE_COMMAND = "chg_on";
        public const string END_CHARGE_COMMAND = "chg_off";

        public const string CLOSE_RELAY_COMMAND = "cr";
        public const string OPEN_RELAY_COMMAND = "or";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    public class ChargeRelay : Relay
    {
        //static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        public ChargeRelay(ICommandChain chain) : base(chain) { }

        public async Task BeginCharge(IEnumerable<DischargeRelay> dischargeRelays)
        {
            await Task.WhenAll(dischargeRelays.Select(d => d.EndDischarge()));

            await Close();
        }

        public async Task EndCharge()
        {
            try
            {
                if (State != RelayState.Open)
                {
                    await Open();
                }
            }
            finally
            {
                //semaphoreSlim.Release();
            }
        }

        protected override async Task Close()
        {
            await chain.Execute(CommandConstants.BEGIN_CHARGE_COMMAND, () => this.State = RelayState.Closed);
        }

        protected override async Task Open()
        {
            await chain.Execute(CommandConstants.END_CHARGE_COMMAND, () => this.State = RelayState.Open);
        }
    }
}

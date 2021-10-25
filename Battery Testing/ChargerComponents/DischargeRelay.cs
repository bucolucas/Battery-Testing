using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    public class DischargeRelay : Relay
    {
        private int relayNumber;
        public int RelayNumber { get { return relayNumber; } }

        public DischargeRelay(int relayNumber, ICommandChain chain) : base(chain)
        {
            this.relayNumber = relayNumber;
        }

        public async Task BeginDischarge(ChargeRelay chargeRelay)
        {
            await chargeRelay.EndCharge();
            await Close();
        }

        public async Task EndDischarge()
        {
            await Open();
        }

        protected override async Task Open()
        {
            if (State != RelayState.Open)
            {
                await chain.Execute(string.Join(' ', CommandConstants.OPEN_RELAY_COMMAND, relayNumber), () => this.State = RelayState.Open);
            }
        }

        protected override async Task Close()
        {
            if (State != RelayState.Closed)
            {
                await chain.Execute(string.Join(' ', CommandConstants.CLOSE_RELAY_COMMAND, relayNumber), () => this.State = RelayState.Closed);
            }
        }
    }
}

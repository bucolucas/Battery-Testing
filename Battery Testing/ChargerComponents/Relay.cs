using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery_Testing
{
    public abstract class Relay
    {
        protected ICommandChain chain;

        protected Relay(ICommandChain chain)
        {
            this.chain = chain;
        }

        public RelayState State { get; set; } = RelayState.None;
        public DateTime LastStateChange { get; set; }
        protected abstract Task Open();
        protected abstract Task Close();
    }

    public enum RelayState
    {
        None,
        Open,
        Closed
    }
}

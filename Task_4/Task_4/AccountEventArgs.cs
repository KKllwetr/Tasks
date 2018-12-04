using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class AccountEventArgs
    {
        public string Message { get; }
        public bool Ready { get; }

        public AccountEventArgs(string mes, bool ready)
        {
            Message = mes;
            Ready = ready;
        }
    }
}

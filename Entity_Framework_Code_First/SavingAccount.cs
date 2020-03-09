using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_WindowsFrom
{
    class SavingAccount
    {
        public Guid SavingAccountId { get; set; }
        public double Amount { get; set; }
        public double Interest { get; set; }
        public int InterestInterval { get; set; }
    }
}

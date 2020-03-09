using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_WindowsFrom
{
    class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public List<SavingAccount> ListSavingAccount { get; set; } = new List<SavingAccount>();
    }
}

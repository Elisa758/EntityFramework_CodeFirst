using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_WindowsFrom
{
    class SavingCalculator
    {
        //public List<SavingAccount> SavingAccounts { get; set; } 

        public static double CalculateTotalSaved(DateTime begin, DateTime end, List<SavingAccount> sa)
        {
            double newAmount = 0;

            int nbYear = Convert.ToInt32((end - begin).TotalDays / 365);
            DateTime date = begin;


            while (begin <= date && date <= end)
            {
                foreach (SavingAccount item in sa)
                {
                        newAmount = item.Amount;
                        newAmount += ((item.Amount * item.Interest)* nbYear);
                }
                date = date.AddMonths(1);
            }
            
            return newAmount;
            


        }

            //MessageBox total épargne
    }
}

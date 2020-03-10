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
            double newAmountY = 0;
            double totalInterestM = 0;
            double totalInterestY = 0;

            int counterMonth = 0;
            int counterYears = 0;

            double totalAmount = 0;
            DateTime date = begin;


            while (begin <= date && date <= end)
            {
                foreach (SavingAccount item in sa)
                {
                        newAmount = item.Amount;
                        newAmount += (item.Amount * item.Interest);
                }
                date = date.AddMonths(1);
            }
            
            return newAmount;
            


        }

            //MessageBox total épargne
    }
}

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
            double totalInterest = 0;
            int counter = 0;
            double totalAmount = 0;
            DateTime date = begin;
            double nbYear = Convert.ToInt32((end - begin).TotalDays / 365);


            //Console.WriteLine(date);
            foreach (SavingAccount item in sa)
            {
                totalAmount = totalAmount + (item.Amount + (item.Amount * item.Interest * nbYear));
                if (item.Interest == 1)
                {

                }
                else if (item.Interest == 12)
                {

                }
                totalAmount=newAmount   
            }
            return totalAmount;
            


        }

            //MessageBox total épargne
    }
}

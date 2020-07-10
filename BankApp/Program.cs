using BankApp.Models;
using FormatCSV.Extensions;
using FormatCSV.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AccountModel> currentDetails = new List<AccountModel>();
            List<AccountDetails> accountDetails = new List<AccountDetails>();

            //get all files from specific path
            var files = Directory.EnumerateFiles("D:\\Abhijeet\\BanApp\\CSV\\", "*");

            //create Account details from CSV data
            foreach (string file in files)
            {
                currentDetails = File.ReadAllLines(file).Skip(1)
                                                       .Select(v => v.ToAccount())
                                                       .ToList();
            }

            //get distinct account names
            var accounts= currentDetails.Select(x => x.AccountNumber).Distinct();

            //Create final output model
            foreach(var account in accounts)
            {
                accountDetails.Add(new AccountDetails
                {
                    AccountNumber = account,
                    TotalCredit = currentDetails.Where(item => item.AccountNumber == account?.ToString()).Sum(item => item.CreditAmount),
                    TotalDebit= currentDetails.Where(item => item.AccountNumber == account?.ToString()).Sum(item => item.DebitAmount),
                    Balance= currentDetails.Where(item => item.AccountNumber == account?.ToString()).Sum(item => item.CreditAmount)- currentDetails.Where(item => item.AccountNumber == account?.ToString()).Sum(item => item.DebitAmount)
                });
            }


            //Final output
            Console.WriteLine("Acct TotalCredits TotalDebits Balance \n");
            foreach (AccountDetails accountDetail in accountDetails)
            {
                Console.WriteLine(accountDetail.AccountNumber + "       "+ accountDetail.TotalCredit + "        " + accountDetail.TotalDebit + "        " + accountDetail.TotalDebit + "\n");
            }
            Console.ReadKey();

        }
    }
}

using FormatCSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatCSV.Extensions
{
    public static class Extension
    {
        public static AccountModel ToAccount(this string csvLines)
        {
            string[] csvLine = csvLines.Split(',');
            AccountModel accountDetails = new AccountModel
            {
                Date = Convert.ToDateTime(csvLine[1]),
                AccountNumber = Convert.ToString(csvLine[2]),
                CreditAmount = csvLine[3] == "-" ? 0 : Convert.ToDouble(csvLine[3]),
                DebitAmount = csvLine[4] == "-" ? 0 : Convert.ToDouble(csvLine[4]),
                ClosureAmount = csvLine[5] == "-" ? 0 : Convert.ToDouble(csvLine[5])
            };

            return accountDetails;
        }
    }
}

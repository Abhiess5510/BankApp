using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Models
{
    public class AccountDetails
    {
        public string AccountNumber { get; set; }
        public double TotalDebit { get; set; }
        public double TotalCredit { get; set; }

        public double Balance { get; set; }
    }
}

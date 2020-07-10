using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatCSV.Models
{
    public class AccountModel
    {
        public string AccountNumber { get; set; }
        public double DebitAmount { get; set; }
        public double CreditAmount { get; set; }
        public double ClosureAmount { get; set; }

        public double Balance { get; set; }
        public DateTime Date { get; set; }
    }
}

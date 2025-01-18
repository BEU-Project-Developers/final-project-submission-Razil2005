using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WInformRazil.Models
{
    public class Borrower
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

    }
}

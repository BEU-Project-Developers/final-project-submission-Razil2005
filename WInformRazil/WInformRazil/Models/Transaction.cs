using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WInformRazil.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public int TakenQuantity { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
    }
}

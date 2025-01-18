namespace WInformRazil.Models
{
    public class Book 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public int Quantity { get; set; }


        public ICollection<Transaction> Transactions { get; set; }
    }
}

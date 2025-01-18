using System.Windows.Forms;
using WInformRazil.DataAccess;
using WInformRazil.Models;

namespace WInformRazil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int bookId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                int borrowerId = 1;

                using (var context = new LibraryDbContext())
                {
                    var borrower = context.Borrowers.FirstOrDefault(b => b.Id == borrowerId);
                    var book = context.Books.FirstOrDefault(b => b.Id == bookId);

                    if (borrower != null && book != null)
                    {
                        if (book.Quantity > 0)
                        {
                            var newTransaction = new Transaction
                            {
                                BookId = bookId,
                                BorrowerId = borrower.Id,
                                Book = book,
                                Borrower = borrower,
                                TakenQuantity = 1
                            };

                            var existingTransaction = context.Transactions
                                .FirstOrDefault(t => t.BookId == bookId && t.BorrowerId == borrowerId);

                            if (existingTransaction != null)
                            {
                                existingTransaction.TakenQuantity++;
                            }
                            else
                            {
                                context.Transactions.Add(newTransaction);
                            }

                            book.Quantity--;

                            context.SaveChanges();

                            RefreshDataGridView();

                            MessageBox.Show("Transaction added and book quantity updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("The selected book is out of stock.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book or Borrower not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book from the grid.");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView2.SelectedRows[0];
                int bookId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                int borrowerId = 1;

                using (var context = new LibraryDbContext())
                {
                    var transaction = context.Transactions
                                             .FirstOrDefault(t => t.BookId == bookId && t.BorrowerId == borrowerId);

                    if (transaction != null)
                    {
                        var book = context.Books.FirstOrDefault(b => b.Id == bookId);
                        if (book != null)
                        {
                            book.Quantity += transaction.TakenQuantity;

                            if (transaction.TakenQuantity > 1)
                            {
                                transaction.TakenQuantity--;  
                            }
                            else
                            {
                                context.Transactions.Remove(transaction);  
                            }

                            context.SaveChanges();

                            RefreshDataGridView();

                            MessageBox.Show("Book returned successfully.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching transaction found for the selected book.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a borrowed book to return.");
            }
        }


        private void RefreshDataGridView()
        {
            using (var context = new LibraryDbContext())
            {
                var availableBooks = context.Books.Where(b => b.Quantity > 0).ToList();
                dataGridView1.DataSource = availableBooks;
            }

            using (var context = new LibraryDbContext())
            {
                var borrowedBooks = context.Transactions
                                           .Where(t => t.BorrowerId == 1)
                                           .Select(t => new
                                           {
                                               t.Book.Id,
                                               t.Book.Name,
                                               t.Book.AuthorName,
                                               t.Book.PageCount,
                                               t.TakenQuantity
                                           })
                                           .ToList();
                dataGridView2.DataSource = borrowedBooks;
            }

        }

        private void BtnChangeLogin_Click(object sender, EventArgs e)
        {
            var changeLoginForm = new Forms.ChangeLoginForm();
            changeLoginForm.ShowDialog(this);
        }
    }
}

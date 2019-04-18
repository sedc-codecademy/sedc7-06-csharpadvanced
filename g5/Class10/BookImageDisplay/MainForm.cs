using BooksProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookImageDisplay
{
    public partial class MainForm : Form
    {
        public IEnumerable<Author> authors;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // authors are gotten from http://www.worldswithoutend.com
            BooksLoader booksLoader = new BooksLoader();
            authors = booksLoader.GetAllAuthors();
            lbxAuthors.DataSource = authors;
            lbxAuthors.DisplayMember = "Name";
        }

        private void lbxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lbxAuthors.SelectedItem as Author;
            lbxBooks.DataSource = author.Books;
            lbxBooks.DisplayMember = "Title";
        }

        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lbxAuthors.SelectedItem as Author;
            var book = lbxBooks.SelectedItem as Book;
            var authorInitials = author.Name.Split(' ');
        }
    }
}

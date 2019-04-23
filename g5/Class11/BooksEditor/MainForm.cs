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

namespace BooksEditor
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
            cbxColumnSelector.DataSource = typeof(Book).GetProperties().Select(pi => pi.Name).ToList();
            cbxColumnSelector.SelectedIndex = 0;
        }

        private void lbxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lbxAuthors.SelectedItem as Author;
            lbxBooks.DataSource = author.Books;
            lbxBooks.DisplayMember = cbxColumnSelector.SelectedItem as string;
        }

        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = lbxAuthors.SelectedItem as Author;
            var book = lbxBooks.SelectedItem as Book;
            txtНаслов.Text = book.Наслов;
        }

        private void cbxColumnSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxBooks.DisplayMember = cbxColumnSelector.SelectedItem as string;
        }

        private void btnSaveНаслов_Click(object sender, EventArgs e)
        {
            var book = lbxBooks.SelectedItem as Book;
            book.Наслов = txtНаслов.Text;
        }
    }
}

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

namespace ShowAuthors
{
    public partial class MainForm : Form
    {
        private IEnumerable<Author> authors;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BooksLoader loader = new BooksLoader();
            authors = loader.GetAllAuthors();
            lbxAuthors.DataSource = authors;
            lbxAuthors.DisplayMember = "Name";
        }

        private void lbxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Author author = lbxAuthors.SelectedItem as Author;
            lbxBooks.DataSource = author.Books;
            lbxBooks.DisplayMember = "Title";
        }
    }
}

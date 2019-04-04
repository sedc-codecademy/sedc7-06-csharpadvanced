using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickMe
{
    public partial class MainForm : Form
    {

        public int Counter { get; set; }

        public MainForm()
        {
            Counter = 0;
            InitializeComponent();
        }

        private void WhenButtonClicked(object sender, EventArgs e)
        {
            Counter += 1;
            lblResult.Text = $"I've been clicked {Counter} times!";

            if (Counter >= 10)
            {
                // btnClickMe.Enabled = false;
                btnClickMe.Click -= WhenButtonClicked;
            }
        }
    }
}

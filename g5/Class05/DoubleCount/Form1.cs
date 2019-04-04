using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleCount
{
    public partial class MainForm : Form
    {
        private const string resultFormat = "Total value of the counter is {0}";
        private int OneCounter = 0;
        private int TwoCounter = 0;

        public int TotalCounter { get; set; }

        public MainForm()
        {
            TotalCounter = 0;
            InitializeComponent();
            lblResult.Text = string.Format(resultFormat, TotalCounter);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            TwoCounter += 1;
            TotalCounter += 2;
            lblResult.Text = string.Format(resultFormat, TotalCounter);

            if (TwoCounter >= 10)
            {
                btnTwo.Click -= btnTwo_Click;
                btnTwo.Enabled = false;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            TwoCounter += 1;
            TotalCounter += 2;
            lblResult.Text = string.Format(resultFormat, TotalCounter);

            if (TwoCounter >= 10)
            {
                btnTwo.Click -= btnTwo_Click;
                btnTwo.Enabled = false;
            }
        }
    }
}

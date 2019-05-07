using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAction_MouseEnter(object sender, EventArgs e)
        {
            btnAction.Text = "ACTIVE";
        }

        private void btnAction_MouseLeave(object sender, EventArgs e)
        {
            btnAction.Text = "Not Active";
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

        }
    }
}

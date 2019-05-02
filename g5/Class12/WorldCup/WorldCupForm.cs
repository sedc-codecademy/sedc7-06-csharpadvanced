using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCup
{
    public partial class WorldCupForm : Form
    {
        public WorldCupForm()
        {
            InitializeComponent();
        }

        private void WorldCupForm_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string teams = wc.DownloadString("https://us-central1-sedc-world-cup.cloudfunctions.net/webApi/team-list");
        }
    }
}

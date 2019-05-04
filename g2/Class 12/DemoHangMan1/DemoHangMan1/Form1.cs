using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHangMan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] mk_cities = { "Skopje", "Stip", "Bitola", "Veles", "Tetovo", "Kumanovo", "Strumica",
            "Kocani", "Vinica","Delcevo","Gevgelija","Ohrid","Resen","Prilep","Kavadarci","Gostivar",
        "Negotino","Berovo","Kicevo","Struga","Radovis","Valandovo","Debar","Dojran","Probistip","Kratovo",
        "Demirhisar","KrivaPalanka","Pehcevo","Dracevo","DemirKapija","Bogdanci"  };
        string[] countries = { "Macedonia", "Bulgaria", "Greece", "Serbia", "Albania", "Turkey",
            "Croatia", "Bosnia","Germany","Italy","Spain","Portugal","France","England","Sweden","Norway",
        "Romania","Russia","Chehia","Slovakia","Poland","Denmark","Finland","Belgium","Switzerland",
        "Austria","Slovenia","Malta","Ireland","Estonia","Ukraine","Georgia","Ermenia","Cyprus","Belorussia",
        "Hungary","Latvia","Iceland","Moldova","Israel","Luxembourg","Netherlands","Andora","Azerbaijan" };
        string[] words;
        string randomWord;
        Random rnd = new Random();
        List<Label> labels = new List<Label>();
        Button[] alphabetButtons;
        bool ignore = false;
        int stage = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            alphabetButtons = this.Controls.OfType<Button>().Except(new Button[] { btnNew }).ToArray();
            foreach(Button btn in alphabetButtons)
            {
                btn.Click += new EventHandler(btn_Click);
            }
            btnNew.PerformClick();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (ignore == true) return;
            Button btn = (Button)sender;
            btn.Enabled = false;
            foreach (Label lbl in labels)
            {
                if(lbl.Tag.ToString() == btn.Text)
                {
                    lbl.Text = btn.Text;
                }
            }
            for (int i = 1; i<labels.Count(); i++)
            {
                labels[i].Left = labels[i - 1].Right;
            }
            if(labels.All(lbl=>lbl.Text != btn.Text))
            {
                stage++;
            }
            if(labels.All(lbl=>lbl.Text != " ") || stage == 10)
            {
                ignore = true;
            }
            else
            {
                ignore = false;
            }
            this.Invalidate();

            if (YouDidIt() == true)
            {
                MessageBox.Show("Congrats", "You did it", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (YouLostIt() == true)
            {
                MessageBox.Show("Sorry " + randomWord, "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool YouDidIt()
        {
            return labels.All(lbl => lbl.Text != " ");
        }
        private bool YouLostIt()
        {
            return stage >= 10;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "MK cities":
                    words = mk_cities;
                    break;
                case "Countries":
                    words = countries;
                    break;
                default:
                    words = mk_cities;
                    break;
            }
            randomWord = words[rnd.Next(0, words.Length)].ToUpper();
            foreach (Label lbl in labels)
            {
                lbl.Dispose();
            }
            foreach (Button btn in alphabetButtons)
            {
                btn.Enabled = true;
            }
            labels = new List<Label>();
            int startLabel = button1.Left;
            foreach (char c in randomWord)
            {
                Label lbl = new Label();
                lbl.Location = new Point(startLabel, 250);
                lbl.Text = " ";
                lbl.Tag = c.ToString();
                lbl.Font = new Font(this.Font.Name, 25, FontStyle.Underline);
                lbl.AutoSize = true;
                labels.Add(lbl);
                this.Controls.Add(lbl);
                startLabel = lbl.Right;
            }
            ignore = false;
            stage = 0;
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (stage >= 1) e.Graphics.DrawLine(new Pen(Color.Black, 2), 85, 190, 210, 190);
            if (stage >= 2) e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 190, 148, 50);
            if (stage >= 3) e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 50, 198, 50);
            if (stage >= 4) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 50, 198, 70);
            if (stage >= 5) e.Graphics.DrawEllipse(new Pen(Color.Black, 2), new Rectangle(188, 70, 20, 20));
            if (stage >= 6) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 90, 198, 130);
            if (stage >= 7) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 95, 183, 115);
            if (stage >= 8) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 95, 213, 115);
            if (stage >= 9) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 130, 183, 170);
            if (stage >= 10) e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 130, 213, 170);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            btnNew.PerformClick();
        }
    }
}

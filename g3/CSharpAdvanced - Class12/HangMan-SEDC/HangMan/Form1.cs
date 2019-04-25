using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangMan {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Paint += Form1_Paint;
        }

        string[] MK_cities = { "Skopje", "Stip", "Bitola", "Veles", "Tetovo", "Kumanovo", "Strumica",
            "Kocani", "Vinica","Delcevo","Gevgelija","Ohrid","Resen","Prilep","Kavadarci","Gostivar",
        "Negotino","Berovo","Kicevo","Struga","Radovis","Valandovo","Debar","Dojran","Probistip","Kratovo",
        "Demirhisar","KrivaPalanka","Pehcevo","Dracevo","DemirKapija","Bogdanci","SvetiNikole"};

        string[] Countries = { "Macedonia", "Bulgaria", "Greece", "Serbia", "Albania", "Turkey",
            "Croatia", "Bosnia","Germany","Italy","Spain","Portugal","France","England","Sweden","Norway",
        "Romania","Russia","Chehia","Slovakia","Poland","Denmark","Finland","Belgium","Switzerland",
        "Austria","Slovenia","Malta","Ireland","Estonia","Ukraine","Georgia","Armenia","Cyprus","Belorussia",
        "Hungary","Latvia","Iceland","Moldova","Israel","Luxembourg","Netherlands","Andora","Azerbaijan",
            "Lithuania","Andora" };

        string[] words;

        Random r = new Random();
        List<Label> labels = new List<Label>();
        Button[] alphabetButtons;
        bool ignore = false;
        int stage = 0;
        string randomWord;

        private void Form1_Load(object sender, EventArgs e) {
            this.DoubleBuffered = true;
            alphabetButtons = this.Controls.OfType<Button>().Except(new Button[] { btnNew }).ToArray();
            Array.ForEach(alphabetButtons, b => b.Click += btn_Click);
            comboBox1.Text = "-- Choose --";
            btnNew.PerformClick();             
        }

        private void btn_Click(object sender, EventArgs e) {
            if (ignore)
                return;
            Button b = (Button)sender;
            b.Enabled = false;

            Array.ForEach(labels.ToArray(), lbl => lbl.Text = lbl.Tag.ToString() == b.Text ? b.Text : lbl.Text);

            for (int i = 1; i <= labels.Count - 1; i++) {
                labels[i].Left = labels[i - 1].Right;
            }
            if (labels[labels.Count - 1].Right > this.ClientSize.Width - 14) {
                this.SetClientSizeCore(labels[labels.Count - 1].Right + 14, 250);
            }

            stage += !labels.Any(lbl => lbl.Text == b.Text) ? 1 : 0;
            ignore = labels.All(lbl => lbl.Text != " ") || stage == 10; 

            this.Invalidate(); //Send a Paint message to the form

            if (YouDidIt()) {
                MessageBox.Show("Congratulations", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (YouLostIt()) {
                MessageBox.Show("It's " + randomWord.ToUpper(), "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {

            string choice = comboBox1.Text;
            switch (choice) {
                case "MK Cities":
                    words = MK_cities;
                    break;
                case "Countries":
                    words = Countries;
                    break;
                default:
                    words = MK_cities;
                    break;
            }
             
            string word = words[r.Next(0, words.Length)].ToUpper(); //Choose a new random word
            randomWord = word; //save the random word
            Array.ForEach(this.Controls.OfType<Label>().ToArray(), lbl => lbl.Dispose()); //must dispose the labels, like buttons are in Form1.Designer.cs
            Array.ForEach(alphabetButtons, b => b.Enabled = true); //Enable buttons on New click
            labels = new List<Label>(); //refresh the labes on New click
            int startX = 14;
            foreach (var c in word) {
                Label lbl = new Label();
                lbl.Text = " ";
                lbl.Font = new Font(this.Font.Name, 25, FontStyle.Underline);
                lbl.Location = new Point(startX, 250);
                lbl.Tag = c.ToString();
                lbl.AutoSize = true;
                this.Controls.Add(lbl);
                labels.Add(lbl);
                startX = lbl.Right;
            }

            //Clears up the Painting
            ignore = false;
            stage = 0;
            this.Invalidate(); //Send an Empty Paint message to the form this time
        }

        private void Form1_Paint(object sender, PaintEventArgs e) { 
            if (stage >= 1) {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 85, 190, 210, 190);
            }
            if (stage >= 2) {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 190, 148, 50);
            }
            if (stage >= 3) {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 148, 50, 198, 50);
            }
            if (stage >= 4) {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 198, 50, 198, 70);
            }
            if (stage >= 5) {
                e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(188, 70, 20, 20));
            }
            if (stage >= 6) {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 198, 90, 198, 130);
            }
            if (stage >= 7) {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 198, 95, 183, 115);
            }
            if (stage >= 8) {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 198, 95, 213, 115);
            }
            if (stage >= 9) {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 198, 130, 183, 170);
            }
            if (stage >= 10) {
                e.Graphics.DrawLine(new Pen(Color.Red, 2), 198, 130, 213, 170);
            }
        }

        private bool YouDidIt() {
            return labels.All(lbl => lbl.Text != " ");
        }

        private bool YouLostIt() {
            return stage >= 10;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e) {
            this.DoubleBuffered = true; 
            btnNew.PerformClick();
        }

    }
}

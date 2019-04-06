using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDelegatesAndAnonymousMethods {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
            //1. Creates a button in the left upper corner
            Button Button1 = new Button();
            Button1.Width = 100;
            Button1.Text = "Button 1: click me";
            //EventHandler is Void delegate. See its definition with F12. 
            Button1.Click += new EventHandler(Button1_Click);
            this.Controls.Add(Button1);

            Button Button2 = new Button();
            Button2.Location = new Point(50, 50);
            Button2.Width = 100;
            Button2.Text = "Button 2: click me";
            this.Controls.Add(Button2);

            //Nameless delegate call
            Button2.Click += delegate (object obj, EventArgs ea) {
                MessageBox.Show("Nameless delegate is called.");
            };

            Button Button3 = new Button();
            Button3.Location = new Point(100, 100);
            Button3.Width = 100;
            Button3.Text = "Button 3: click me";
            this.Controls.Add(Button3);

            //Nameless delegate and parameterless call == anonymous method
            Button3.Click += delegate {
                MessageBox.Show("Nameless delegate, parameterless call.");
            };
        }

        private void Button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Button_Click() method is called.");
        }
    }
}

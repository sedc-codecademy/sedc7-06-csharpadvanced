using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        private string selectedPath = string.Empty;

        private PictureBox pictureBox = new PictureBox();


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                LoadFilesFromPath();
            }
        }

        private void LoadFilesFromPath()
        {
            var result = Directory.EnumerateFiles(selectedPath);
                // .Concat(new List<string> { "MeNemet.jpg" });
            lbxFiles.DataSource = result.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // MessageBox.Show("Closing");
            //var result = MessageBox.Show("Are you sure?", "Exiting application", MessageBoxButtons.YesNo);
            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // MessageBox.Show("Closed");
        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filename = lbxFiles.SelectedItem as string;
            lblFileName.Text = filename;
            lblStatus.Text = string.Empty;
            if (!File.Exists(filename))
            {
                lblStatus.Text = "File does not exist";
                return;
            }
            var goodExtensions = new List<string> { ".jpg", ".jpeg", ".gif", ".png" };

            if (goodExtensions.All(ext => ext != Path.GetExtension(filename)))
            {
                lblStatus.Text = "Invalid image extension";
                return;
            }
            var fileInfo = new FileInfo(filename);
            lblStatus.Text = $"{fileInfo.Length / 1024}kB";

            pictureBox.Load(filename);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox.Location = new Point(26, 356);
            pictureBox.Size = new Size(874, 311);
            pictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            Controls.Add(pictureBox);
        }
    }
}

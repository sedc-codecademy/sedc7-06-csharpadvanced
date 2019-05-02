using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var input = (int)numInput.Value;

            ThreadStart ts = new ThreadStart(() => { lblResult.Text = Fibonacci(input).ToString(); });
            Thread thread = new Thread(ts);
            thread.Start();
        }

        private long Fibonacci(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number == 1)
            {
                return 1;
            }
            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        private void btnAnalyzeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblAnalisysResult.Text = FindMostCommonByte(dialog.FileName);
            }
        }

        private string FindMostCommonByte(string filename)
        {
            var bytes = File.ReadAllBytes(filename);
            var mostCommon = bytes.GroupBy(b => b).Select(g => new
            {
                Byte = g.Key,
                Count = g.Count()
            }).OrderByDescending(g => g.Count).First();

            return $"The most common byte is {mostCommon.Byte:x2} with {mostCommon.Count} occurences";
        }

        private void btnAnalFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int counter = 0;
                var lockObject = new object();
                var fileNames = Directory.GetFiles(dialog.SelectedPath);
                lbxFilenames.Items.AddRange(fileNames);
                lblCounter.Text = $"{counter}/{fileNames.Length}";

                foreach (var filename in fileNames)
                {
                    Thread thread = new Thread(new ThreadStart(() =>
                    {
                        var commonByte = FindMostCommonByte(filename);
                        lock (lockObject)
                        {
                            counter = counter + 1;
                            lbxAnalResult.Items.Add($"{counter} ({filename}): {commonByte}");
                            lblCounter.Text = $"{counter}/{fileNames.Length}";
                        }
                    }));
                    thread.Start();
                }
            }
        }
    }
}

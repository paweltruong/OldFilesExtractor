using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OldFileExtractor
{
    public partial class AudioFileConverter : UserControl
    {
        int soxRate;
        int soxBits;
        string soxEncoding;
        string soxPath;


        public AudioFileConverter()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            if (openFileDialogInput.ShowDialog() == DialogResult.OK)
            {
                listViewInput.Items.Clear();
                foreach (var file in openFileDialogInput.FileNames)
                {
                    AddFileToInputList(file);
                }
            }
            TrySetDefaultOutput();
            VerifyForm();
        }

        private void listViewInput_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listViewInput_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null && data is string[])
            {
                var fileArray = data as string[];
                if (fileArray != null)
                {
                    foreach (var file in fileArray)
                    {
                        AddFileToInputList(file);
                    }
                }
            }
            TrySetDefaultOutput();
            VerifyForm();
        }

        void AddFileToInputList(string file)
        {
            var newItem = new ListViewItem(Path.GetFileName(file).Trim());
            var fi = new FileInfo(file);
            newItem.SubItems.Add(String.Format("{0} Kb", (fi.Length / 1024)));
            newItem.SubItems.Add(file);
            listViewInput.Items.Add(newItem);
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {

            VerifyForm();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewInput.Items)
            {
                Convert(item.SubItems[2].Text);
            }
        }

        void VerifyForm()
        {
            buttonConvert.Enabled = CanStartConvert();
        }

        bool CanStartConvert()
        {
            //SOX
            if (!Directory.Exists(textBoxSOX.Text))
            {
                MessageBox.Show("SOX Error", "SOX tools directory is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var soxpath = Path.Combine(textBoxSOX.Text, "sox.exe");
            if(!File.Exists(soxpath))
            {
                MessageBox.Show("SOX Error", "sox.exe was not found at " + soxpath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            soxPath = soxpath;

            //Input
            if (listViewInput.Items.Count == 0)
            {
                MessageBox.Show("Iput Error", "There is no input provided " + soxpath, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Output
            bool outputDirValid = false;
            if (!Directory.Exists(textBoxOutput.Text))
            {
                try
                {
                    var dir = Directory.CreateDirectory(textBoxOutput.Text);
                    outputDirValid = Directory.Exists(textBoxOutput.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Output Error", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return outputDirValid;
            }
            else
            {
                outputDirValid = true;
            }

            //SOX params
            if(!int.TryParse(textBoxSOXRate.Text, out soxRate))
            {
                MessageBox.Show("SOX Error", "Invalid rate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxSOXEncoding.Text))
            {
                MessageBox.Show("SOX Error", "Invalid encoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            soxEncoding = textBoxSOXEncoding.Text.Trim();
            if (!int.TryParse(textBoxSOXBits.Text, out soxBits))
            {
                MessageBox.Show("SOX Error", "Invalid bits", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        bool TrySetDefaultOutput()
        {
            if (string.IsNullOrEmpty(textBoxOutput.Text))
            {
                if (listViewInput.Items.Count > 0)
                {
                    var firstPath = listViewInput.Items[0].SubItems[2].Text.Trim();
                    var dir = Path.GetDirectoryName(firstPath);
                    var di = Directory.CreateDirectory(Path.Combine( dir, "output"));
                    if (Directory.Exists(di.FullName))
                    {
                        textBoxOutput.Text = di.FullName;
                        return true;
                    }
                }
            }
            return false;
        }

        void Convert(string binarySourceFile)
        {
            var outputFile = Path.Combine(textBoxOutput.Text, Path.GetFileNameWithoutExtension(binarySourceFile));

            var args = String.Format("-r {0} -e {1} -b {2} \"{3}\" \"{4}.wav\"", soxRate, soxEncoding, soxBits,
                    binarySourceFile,
                    outputFile
                    );

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = soxPath,
                    Arguments =args,

                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };


proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string? line = proc.StandardOutput.ReadLine();
                if (line == null)
                {
                    
                }
            }
        }
    }
}

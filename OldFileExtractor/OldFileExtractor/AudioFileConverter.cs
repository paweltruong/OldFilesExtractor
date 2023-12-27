using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        void AddFileToInputList(string file)
        {
            var newItem = new ListViewItem(Path.GetFileName(file).Trim());
            var fi = new FileInfo(file);
            newItem.SubItems.Add( String.Format("{0} Kb",(fi.Length / 1024)));
            newItem.SubItems.Add(file);
            listViewInput.Items.Add(newItem);
        }
    }
}

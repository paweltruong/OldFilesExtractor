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
            newItem.SubItems.Add(String.Format("{0} Kb", (fi.Length / 1024)));
            newItem.SubItems.Add(file);
            listViewInput.Items.Add(newItem);
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewInput.Items)
            {
                Convert(item.SubItems[2].Text);
            }
        }

        void Convert(string binarySourceFile)
        {
            Console.WriteLine(String.Format("Begin Reading {0}:\r\n", binarySourceFile));

            //using (var fs = File.OpenRead(binarySourceFile))
            //{
            //    fs.Rea
            //}

            byte[] content = File.ReadAllBytes(binarySourceFile);
            Console.Write(content.ToString());
            Console.WriteLine(String.Format("End Reading {0}:\r\n", binarySourceFile));


            //using (FileStream fs = File.OpenRead(binarySourceFile))
            ////{
            ////    //Convert.ToString(b, 2)
            ////}

            //using (BinaryReader reader = new BinaryReader(fs))
            //{
            //    // Read in all pairs.
            //    while (reader.BaseStream.Position != reader.BaseStream.Length)
            //    {
            //        Item item = new Item();
            //        item.UniqueId = reader.ReadString();
            //        item.StringUnique = reader.ReadString();
            //        result.Add(item);
            //    }
            //}
            //return result;
        }
    }
}

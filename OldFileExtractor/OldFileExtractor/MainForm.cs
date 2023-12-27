namespace OldFileExtractor
{
    public partial class MainForm : Form
    {
        AudioFileConverter audioFileConverter;

        public MainForm()
        {
            InitializeComponent();
        }

        private void audioFilesConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (audioFileConverter == null)
            {
                audioFileConverter = new AudioFileConverter();
                
            }
            panelContent.Controls.Add(audioFileConverter);
            audioFileConverter.Dock = DockStyle.Fill;
        }
    }
}

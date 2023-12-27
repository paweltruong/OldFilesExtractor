namespace OldFileExtractor
{
    partial class AudioFileConverter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            openFileDialogInput = new OpenFileDialog();
            buttonInput = new Button();
            buttonOutput = new Button();
            textBoxOutput = new TextBox();
            listViewInput = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            labelOutput = new Label();
            buttonConvert = new Button();
            openFileDialogOutput = new OpenFileDialog();
            buttonSOX = new Button();
            toolTip1 = new ToolTip(components);
            textBoxSOX = new TextBox();
            labelSOXRate = new Label();
            textBoxSOXRate = new TextBox();
            labelSOXEncoding = new Label();
            textBoxSOXEncoding = new TextBox();
            labelSOXBits = new Label();
            textBoxSOXBits = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 41);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Audio file converter";
            // 
            // openFileDialogInput
            // 
            openFileDialogInput.FileName = "openFileDialogSource";
            openFileDialogInput.Multiselect = true;
            // 
            // buttonInput
            // 
            buttonInput.Location = new Point(36, 108);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(171, 23);
            buttonInput.TabIndex = 1;
            buttonInput.Text = "Select source files";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(36, 137);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(171, 23);
            buttonOutput.TabIndex = 2;
            buttonOutput.Text = "Select output";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOutput.Location = new Point(293, 137);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(387, 23);
            textBoxOutput.TabIndex = 3;
            // 
            // listViewInput
            // 
            listViewInput.AllowDrop = true;
            listViewInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewInput.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewInput.Location = new Point(0, 344);
            listViewInput.Name = "listViewInput";
            listViewInput.Size = new Size(705, 172);
            listViewInput.TabIndex = 4;
            listViewInput.UseCompatibleStateImageBehavior = false;
            listViewInput.View = View.Details;
            listViewInput.DragDrop += listViewInput_DragDrop;
            listViewInput.DragEnter += listViewInput_DragEnter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Filename";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Path";
            columnHeader3.Width = 400;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(222, 141);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(65, 15);
            labelOutput.TabIndex = 5;
            labelOutput.Text = "Output dir:";
            // 
            // buttonConvert
            // 
            buttonConvert.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonConvert.Enabled = false;
            buttonConvert.Location = new Point(292, 291);
            buttonConvert.Name = "buttonConvert";
            buttonConvert.Size = new Size(75, 23);
            buttonConvert.TabIndex = 6;
            buttonConvert.Text = "Convert";
            buttonConvert.UseVisualStyleBackColor = true;
            buttonConvert.Click += buttonConvert_Click;
            // 
            // openFileDialogOutput
            // 
            openFileDialogOutput.FileName = "openFileDialog1";
            // 
            // buttonSOX
            // 
            buttonSOX.Location = new Point(36, 65);
            buttonSOX.Name = "buttonSOX";
            buttonSOX.Size = new Size(171, 23);
            buttonSOX.TabIndex = 0;
            buttonSOX.Text = "Select SOX location";
            toolTip1.SetToolTip(buttonSOX, "https://sourceforge.net/projects/sox/");
            buttonSOX.UseVisualStyleBackColor = true;
            // 
            // textBoxSOX
            // 
            textBoxSOX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSOX.Location = new Point(242, 65);
            textBoxSOX.Name = "textBoxSOX";
            textBoxSOX.ReadOnly = true;
            textBoxSOX.Size = new Size(438, 23);
            textBoxSOX.TabIndex = 8;
            textBoxSOX.Text = "E:\\Program Files (x86)\\sox-14-4-2";
            // 
            // labelSOXRate
            // 
            labelSOXRate.AutoSize = true;
            labelSOXRate.Location = new Point(36, 180);
            labelSOXRate.Name = "labelSOXRate";
            labelSOXRate.Size = new Size(33, 15);
            labelSOXRate.TabIndex = 9;
            labelSOXRate.Text = "Rate:";
            // 
            // textBoxSOXRate
            // 
            textBoxSOXRate.Location = new Point(136, 180);
            textBoxSOXRate.Name = "textBoxSOXRate";
            textBoxSOXRate.Size = new Size(100, 23);
            textBoxSOXRate.TabIndex = 10;
            textBoxSOXRate.Text = "11025";
            // 
            // labelSOXEncoding
            // 
            labelSOXEncoding.AutoSize = true;
            labelSOXEncoding.Location = new Point(36, 213);
            labelSOXEncoding.Name = "labelSOXEncoding";
            labelSOXEncoding.Size = new Size(60, 15);
            labelSOXEncoding.TabIndex = 11;
            labelSOXEncoding.Text = "Encoding:";
            // 
            // textBoxSOXEncoding
            // 
            textBoxSOXEncoding.Location = new Point(136, 209);
            textBoxSOXEncoding.Name = "textBoxSOXEncoding";
            textBoxSOXEncoding.Size = new Size(100, 23);
            textBoxSOXEncoding.TabIndex = 12;
            textBoxSOXEncoding.Text = "signed";
            // 
            // labelSOXBits
            // 
            labelSOXBits.AutoSize = true;
            labelSOXBits.Location = new Point(36, 244);
            labelSOXBits.Name = "labelSOXBits";
            labelSOXBits.Size = new Size(29, 15);
            labelSOXBits.TabIndex = 13;
            labelSOXBits.Text = "Bits:";
            // 
            // textBoxSOXBits
            // 
            textBoxSOXBits.Location = new Point(136, 244);
            textBoxSOXBits.Name = "textBoxSOXBits";
            textBoxSOXBits.Size = new Size(100, 23);
            textBoxSOXBits.TabIndex = 14;
            textBoxSOXBits.Text = "8";
            // 
            // AudioFileConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxSOXBits);
            Controls.Add(labelSOXBits);
            Controls.Add(textBoxSOXEncoding);
            Controls.Add(labelSOXEncoding);
            Controls.Add(textBoxSOXRate);
            Controls.Add(labelSOXRate);
            Controls.Add(textBoxSOX);
            Controls.Add(buttonSOX);
            Controls.Add(buttonConvert);
            Controls.Add(labelOutput);
            Controls.Add(listViewInput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonOutput);
            Controls.Add(buttonInput);
            Controls.Add(label1);
            Name = "AudioFileConverter";
            Size = new Size(705, 516);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private OpenFileDialog openFileDialogInput;
        private Button buttonInput;
        private Button buttonOutput;
        private TextBox textBoxOutput;
        private ListView listViewInput;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label labelOutput;
        private Button buttonConvert;
        private OpenFileDialog openFileDialogOutput;
        private Button buttonSOX;
        private ToolTip toolTip1;
        private TextBox textBoxSOX;
        private Label labelSOXRate;
        private TextBox textBoxSOXRate;
        private Label labelSOXEncoding;
        private TextBox textBoxSOXEncoding;
        private Label labelSOXBits;
        private TextBox textBoxSOXBits;
    }
}

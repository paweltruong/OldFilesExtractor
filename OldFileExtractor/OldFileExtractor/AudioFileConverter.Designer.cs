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
            buttonInput.Location = new Point(70, 82);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(171, 23);
            buttonInput.TabIndex = 1;
            buttonInput.Text = "Select source files";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new Point(384, 82);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new Size(171, 23);
            buttonOutput.TabIndex = 2;
            buttonOutput.Text = "Select output";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(455, 115);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(100, 23);
            textBoxOutput.TabIndex = 3;
            // 
            // listViewInput
            // 
            listViewInput.AllowDrop = true;
            listViewInput.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewInput.Dock = DockStyle.Bottom;
            listViewInput.Location = new Point(0, 285);
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
            labelOutput.Location = new Point(380, 118);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(65, 15);
            labelOutput.TabIndex = 5;
            labelOutput.Text = "Output dir:";
            // 
            // buttonConvert
            // 
            buttonConvert.Location = new Point(499, 198);
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
            // AudioFileConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonConvert);
            Controls.Add(labelOutput);
            Controls.Add(listViewInput);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonOutput);
            Controls.Add(buttonInput);
            Controls.Add(label1);
            Name = "AudioFileConverter";
            Size = new Size(705, 457);
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
    }
}

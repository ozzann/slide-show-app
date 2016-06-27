namespace MySlideShow
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.photoDirLabel = new System.Windows.Forms.Label();
            this.photoDirTextBox = new System.Windows.Forms.TextBox();
            this.photoDirBrowseBtn = new System.Windows.Forms.Button();
            this.videoOutputLabel = new System.Windows.Forms.Label();
            this.videoOutputTextBox = new System.Windows.Forms.TextBox();
            this.videoOutputBrowseBtn = new System.Windows.Forms.Button();
            this.videoParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.randomSortRadio = new System.Windows.Forms.RadioButton();
            this.timeSortRadio = new System.Windows.Forms.RadioButton();
            this.titleSortRadio = new System.Windows.Forms.RadioButton();
            this.sortingLabel = new System.Windows.Forms.Label();
            this.slideDurationNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.slideDurationLabel = new System.Windows.Forms.Label();
            this.videoCodecComboBox = new System.Windows.Forms.ComboBox();
            this.videoCodecLabel = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.videoParamsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideDurationNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // photoDirLabel
            // 
            this.photoDirLabel.AutoSize = true;
            this.photoDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoDirLabel.Location = new System.Drawing.Point(50, 36);
            this.photoDirLabel.Name = "photoDirLabel";
            this.photoDirLabel.Size = new System.Drawing.Size(97, 15);
            this.photoDirLabel.TabIndex = 0;
            this.photoDirLabel.Text = "Photos directory:";
            // 
            // photoDirTextBox
            // 
            this.photoDirTextBox.Location = new System.Drawing.Point(169, 35);
            this.photoDirTextBox.Name = "photoDirTextBox";
            this.photoDirTextBox.Size = new System.Drawing.Size(249, 20);
            this.photoDirTextBox.TabIndex = 1;
            this.photoDirTextBox.TextChanged += new System.EventHandler(this.directoryTextBox_TextChanged);
            // 
            // photoDirBrowseBtn
            // 
            this.photoDirBrowseBtn.Location = new System.Drawing.Point(424, 35);
            this.photoDirBrowseBtn.Name = "photoDirBrowseBtn";
            this.photoDirBrowseBtn.Size = new System.Drawing.Size(35, 20);
            this.photoDirBrowseBtn.TabIndex = 2;
            this.photoDirBrowseBtn.Text = "...";
            this.photoDirBrowseBtn.UseVisualStyleBackColor = true;
            this.photoDirBrowseBtn.Click += new System.EventHandler(this.photoDirBrowseBtn_Click);
            // 
            // videoOutputLabel
            // 
            this.videoOutputLabel.AutoSize = true;
            this.videoOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videoOutputLabel.Location = new System.Drawing.Point(43, 73);
            this.videoOutputLabel.Name = "videoOutputLabel";
            this.videoOutputLabel.Size = new System.Drawing.Size(104, 15);
            this.videoOutputLabel.TabIndex = 3;
            this.videoOutputLabel.Text = "Video destination:";
            // 
            // videoOutputTextBox
            // 
            this.videoOutputTextBox.Location = new System.Drawing.Point(169, 73);
            this.videoOutputTextBox.Name = "videoOutputTextBox";
            this.videoOutputTextBox.Size = new System.Drawing.Size(249, 20);
            this.videoOutputTextBox.TabIndex = 4;
            // 
            // videoOutputBrowseBtn
            // 
            this.videoOutputBrowseBtn.Location = new System.Drawing.Point(424, 73);
            this.videoOutputBrowseBtn.Name = "videoOutputBrowseBtn";
            this.videoOutputBrowseBtn.Size = new System.Drawing.Size(35, 20);
            this.videoOutputBrowseBtn.TabIndex = 5;
            this.videoOutputBrowseBtn.Text = "...";
            this.videoOutputBrowseBtn.UseVisualStyleBackColor = true;
            this.videoOutputBrowseBtn.Click += new System.EventHandler(this.videoOutputBrowseBtn_Click);
            // 
            // videoParamsGroupBox
            // 
            this.videoParamsGroupBox.Controls.Add(this.randomSortRadio);
            this.videoParamsGroupBox.Controls.Add(this.timeSortRadio);
            this.videoParamsGroupBox.Controls.Add(this.titleSortRadio);
            this.videoParamsGroupBox.Controls.Add(this.sortingLabel);
            this.videoParamsGroupBox.Controls.Add(this.slideDurationNumUpDown);
            this.videoParamsGroupBox.Controls.Add(this.slideDurationLabel);
            this.videoParamsGroupBox.Controls.Add(this.videoCodecComboBox);
            this.videoParamsGroupBox.Controls.Add(this.videoCodecLabel);
            this.videoParamsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.videoParamsGroupBox.Location = new System.Drawing.Point(36, 120);
            this.videoParamsGroupBox.Name = "videoParamsGroupBox";
            this.videoParamsGroupBox.Size = new System.Drawing.Size(423, 142);
            this.videoParamsGroupBox.TabIndex = 6;
            this.videoParamsGroupBox.TabStop = false;
            this.videoParamsGroupBox.Text = "Video characteristics";
            // 
            // randomSortRadio
            // 
            this.randomSortRadio.AutoSize = true;
            this.randomSortRadio.Location = new System.Drawing.Point(306, 97);
            this.randomSortRadio.Name = "randomSortRadio";
            this.randomSortRadio.Size = new System.Drawing.Size(68, 19);
            this.randomSortRadio.TabIndex = 7;
            this.randomSortRadio.TabStop = true;
            this.randomSortRadio.Text = "random";
            this.randomSortRadio.UseVisualStyleBackColor = true;
            // 
            // timeSortRadio
            // 
            this.timeSortRadio.AutoSize = true;
            this.timeSortRadio.Location = new System.Drawing.Point(192, 97);
            this.timeSortRadio.Name = "timeSortRadio";
            this.timeSortRadio.Size = new System.Drawing.Size(96, 19);
            this.timeSortRadio.TabIndex = 6;
            this.timeSortRadio.TabStop = true;
            this.timeSortRadio.Text = "creation time";
            this.timeSortRadio.UseVisualStyleBackColor = true;
            // 
            // titleSortRadio
            // 
            this.titleSortRadio.AutoSize = true;
            this.titleSortRadio.Location = new System.Drawing.Point(111, 97);
            this.titleSortRadio.Name = "titleSortRadio";
            this.titleSortRadio.Size = new System.Drawing.Size(44, 19);
            this.titleSortRadio.TabIndex = 5;
            this.titleSortRadio.TabStop = true;
            this.titleSortRadio.Text = "title";
            this.titleSortRadio.UseVisualStyleBackColor = true;
            // 
            // sortingLabel
            // 
            this.sortingLabel.AutoSize = true;
            this.sortingLabel.Location = new System.Drawing.Point(10, 95);
            this.sortingLabel.Name = "sortingLabel";
            this.sortingLabel.Size = new System.Drawing.Size(84, 15);
            this.sortingLabel.TabIndex = 4;
            this.sortingLabel.Text = "Sort photos by";
            // 
            // slideDurationNumUpDown
            // 
            this.slideDurationNumUpDown.Location = new System.Drawing.Point(341, 41);
            this.slideDurationNumUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.slideDurationNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.slideDurationNumUpDown.Name = "slideDurationNumUpDown";
            this.slideDurationNumUpDown.Size = new System.Drawing.Size(62, 21);
            this.slideDurationNumUpDown.TabIndex = 3;
            this.slideDurationNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // slideDurationLabel
            // 
            this.slideDurationLabel.AutoSize = true;
            this.slideDurationLabel.Location = new System.Drawing.Point(224, 43);
            this.slideDurationLabel.Name = "slideDurationLabel";
            this.slideDurationLabel.Size = new System.Drawing.Size(111, 15);
            this.slideDurationLabel.TabIndex = 2;
            this.slideDurationLabel.Text = "Slide duration, sec:";
            // 
            // videoCodecComboBox
            // 
            this.videoCodecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoCodecComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.videoCodecComboBox.FormattingEnabled = true;
            this.videoCodecComboBox.Items.AddRange(new object[] {
            "MPEG4",
            "MPEG2",
            "WMV2",
            "WMV1",
            "MSMPEG4v3",
            "MSMPEG4v2",
            "FLV1"});
            this.videoCodecComboBox.Location = new System.Drawing.Point(87, 38);
            this.videoCodecComboBox.Name = "videoCodecComboBox";
            this.videoCodecComboBox.Size = new System.Drawing.Size(98, 23);
            this.videoCodecComboBox.TabIndex = 1;
            // 
            // videoCodecLabel
            // 
            this.videoCodecLabel.AutoSize = true;
            this.videoCodecLabel.Location = new System.Drawing.Point(7, 41);
            this.videoCodecLabel.Name = "videoCodecLabel";
            this.videoCodecLabel.Size = new System.Drawing.Size(74, 15);
            this.videoCodecLabel.TabIndex = 0;
            this.videoCodecLabel.Text = "Video codec";
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertBtn.Location = new System.Drawing.Point(329, 297);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(130, 30);
            this.convertBtn.TabIndex = 7;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.videoParamsGroupBox);
            this.Controls.Add(this.videoOutputBrowseBtn);
            this.Controls.Add(this.videoOutputTextBox);
            this.Controls.Add(this.videoOutputLabel);
            this.Controls.Add(this.photoDirBrowseBtn);
            this.Controls.Add(this.photoDirTextBox);
            this.Controls.Add(this.photoDirLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide show";
            this.videoParamsGroupBox.ResumeLayout(false);
            this.videoParamsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideDurationNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label photoDirLabel;
        private System.Windows.Forms.TextBox photoDirTextBox;
        private System.Windows.Forms.Button photoDirBrowseBtn;
        private System.Windows.Forms.Label videoOutputLabel;
        private System.Windows.Forms.TextBox videoOutputTextBox;
        private System.Windows.Forms.Button videoOutputBrowseBtn;
        private System.Windows.Forms.GroupBox videoParamsGroupBox;
        private System.Windows.Forms.RadioButton randomSortRadio;
        private System.Windows.Forms.RadioButton timeSortRadio;
        private System.Windows.Forms.RadioButton titleSortRadio;
        private System.Windows.Forms.Label sortingLabel;
        private System.Windows.Forms.NumericUpDown slideDurationNumUpDown;
        private System.Windows.Forms.Label slideDurationLabel;
        private System.Windows.Forms.ComboBox videoCodecComboBox;
        private System.Windows.Forms.Label videoCodecLabel;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


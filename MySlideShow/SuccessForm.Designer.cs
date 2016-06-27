namespace MySlideShow
{
    partial class SuccessForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.successResultLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.watchBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // successResultLabel
            // 
            this.successResultLabel.AutoSize = true;
            this.successResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.successResultLabel.Location = new System.Drawing.Point(30, 54);
            this.successResultLabel.Name = "successResultLabel";
            this.successResultLabel.Size = new System.Drawing.Size(270, 15);
            this.successResultLabel.TabIndex = 0;
            this.successResultLabel.Text = "Slide show video has been succesfully recorded.";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.Location = new System.Drawing.Point(225, 114);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // watchBtn
            // 
            this.watchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchBtn.Location = new System.Drawing.Point(123, 114);
            this.watchBtn.Name = "watchBtn";
            this.watchBtn.Size = new System.Drawing.Size(87, 23);
            this.watchBtn.TabIndex = 2;
            this.watchBtn.Text = "Watch it";
            this.watchBtn.UseVisualStyleBackColor = true;
            this.watchBtn.Click += new System.EventHandler(this.watchBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SuccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 181);
            this.Controls.Add(this.watchBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.successResultLabel);
            this.Name = "SuccessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Success";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label successResultLabel;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button watchBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
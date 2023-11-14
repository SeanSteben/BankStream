
namespace BankStream
{
    partial class InfoPassedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInfoPassed = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Information being sent";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxInfoPassed
            // 
            this.textBoxInfoPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfoPassed.Location = new System.Drawing.Point(30, 66);
            this.textBoxInfoPassed.Name = "textBoxInfoPassed";
            this.textBoxInfoPassed.Size = new System.Drawing.Size(482, 518);
            this.textBoxInfoPassed.TabIndex = 4;
            this.textBoxInfoPassed.Text = "";
            // 
            // InfoPassedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 632);
            this.Controls.Add(this.textBoxInfoPassed);
            this.Controls.Add(this.label2);
            this.Name = "InfoPassedForm";
            this.Text = "Information Passing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textBoxInfoPassed;
    }
}
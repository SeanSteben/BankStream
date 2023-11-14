
namespace BankStream
{
    partial class bankForm
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
            this.textBoxBank = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxBank
            // 
            this.textBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBank.Location = new System.Drawing.Point(92, 60);
            this.textBoxBank.Name = "textBoxBank";
            this.textBoxBank.Size = new System.Drawing.Size(354, 242);
            this.textBoxBank.TabIndex = 0;
            this.textBoxBank.Text = "";
            this.textBoxBank.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // bankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 364);
            this.Controls.Add(this.textBoxBank);
            this.Name = "bankForm";
            this.Text = "Bob\'s Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxBank;
    }
}
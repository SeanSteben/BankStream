
namespace BankStream
{
    partial class UserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.buttonSalt = new System.Windows.Forms.Button();
            this.buttonEnterUserName = new System.Windows.Forms.Button();
            this.buttonEnterPassword = new System.Windows.Forms.Button();
            this.labelHash = new System.Windows.Forms.Label();
            this.labelHashedPassword = new System.Windows.Forms.Label();
            this.labelSalt = new System.Windows.Forms.Label();
            this.labelTheSalt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMessageFromBank = new System.Windows.Forms.Label();
            this.buttonCheckBalance = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdrawal = new System.Windows.Forms.Button();
            this.textBoxCheckBalance = new System.Windows.Forms.TextBox();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.textBoxWithdrawal = new System.Windows.Forms.TextBox();
            this.groupBoxSession = new System.Windows.Forms.GroupBox();
            this.groupBoxSignIn.SuspendLayout();
            this.groupBoxSession.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.Controls.Add(this.buttonLogin);
            this.groupBoxSignIn.Controls.Add(this.label3);
            this.groupBoxSignIn.Controls.Add(this.label2);
            this.groupBoxSignIn.Controls.Add(this.textBoxPassword);
            this.groupBoxSignIn.Controls.Add(this.textBoxUserName);
            this.groupBoxSignIn.Location = new System.Drawing.Point(34, 25);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(325, 136);
            this.groupBoxSignIn.TabIndex = 1;
            this.groupBoxSignIn.TabStop = false;
            this.groupBoxSignIn.Text = "Sign in";
            this.groupBoxSignIn.Enter += new System.EventHandler(this.groupBoxSignIn_Enter);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(112, 103);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(112, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(112, 39);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserName.TabIndex = 0;
            // 
            // buttonHash
            // 
            this.buttonHash.Location = new System.Drawing.Point(90, 167);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(75, 23);
            this.buttonHash.TabIndex = 5;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // buttonSalt
            // 
            this.buttonSalt.Location = new System.Drawing.Point(189, 167);
            this.buttonSalt.Name = "buttonSalt";
            this.buttonSalt.Size = new System.Drawing.Size(75, 23);
            this.buttonSalt.TabIndex = 6;
            this.buttonSalt.Text = "Salt";
            this.buttonSalt.UseVisualStyleBackColor = true;
            this.buttonSalt.Click += new System.EventHandler(this.buttonSalt_Click);
            // 
            // buttonEnterUserName
            // 
            this.buttonEnterUserName.Location = new System.Drawing.Point(365, 32);
            this.buttonEnterUserName.Name = "buttonEnterUserName";
            this.buttonEnterUserName.Size = new System.Drawing.Size(75, 52);
            this.buttonEnterUserName.TabIndex = 7;
            this.buttonEnterUserName.Text = "Enter Username";
            this.buttonEnterUserName.UseVisualStyleBackColor = true;
            this.buttonEnterUserName.Click += new System.EventHandler(this.buttonEnterUserName_Click);
            // 
            // buttonEnterPassword
            // 
            this.buttonEnterPassword.Location = new System.Drawing.Point(365, 90);
            this.buttonEnterPassword.Name = "buttonEnterPassword";
            this.buttonEnterPassword.Size = new System.Drawing.Size(75, 47);
            this.buttonEnterPassword.TabIndex = 8;
            this.buttonEnterPassword.Text = "Enter Password";
            this.buttonEnterPassword.UseVisualStyleBackColor = true;
            this.buttonEnterPassword.Click += new System.EventHandler(this.buttonEnterPassword_Click);
            // 
            // labelHash
            // 
            this.labelHash.AutoSize = true;
            this.labelHash.Location = new System.Drawing.Point(6, 205);
            this.labelHash.Name = "labelHash";
            this.labelHash.Size = new System.Drawing.Size(96, 13);
            this.labelHash.TabIndex = 5;
            this.labelHash.Text = "Hashed Password:";
            this.labelHash.Visible = false;
            // 
            // labelHashedPassword
            // 
            this.labelHashedPassword.AutoSize = true;
            this.labelHashedPassword.Location = new System.Drawing.Point(108, 205);
            this.labelHashedPassword.Name = "labelHashedPassword";
            this.labelHashedPassword.Size = new System.Drawing.Size(0, 13);
            this.labelHashedPassword.TabIndex = 9;
            // 
            // labelSalt
            // 
            this.labelSalt.AutoSize = true;
            this.labelSalt.Location = new System.Drawing.Point(6, 218);
            this.labelSalt.Name = "labelSalt";
            this.labelSalt.Size = new System.Drawing.Size(28, 13);
            this.labelSalt.TabIndex = 10;
            this.labelSalt.Text = "Salt:";
            this.labelSalt.Visible = false;
            // 
            // labelTheSalt
            // 
            this.labelTheSalt.AutoSize = true;
            this.labelTheSalt.Location = new System.Drawing.Point(40, 218);
            this.labelTheSalt.Name = "labelTheSalt";
            this.labelTheSalt.Size = new System.Drawing.Size(0, 13);
            this.labelTheSalt.TabIndex = 11;
            this.labelTheSalt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message From Bank:";
            // 
            // labelMessageFromBank
            // 
            this.labelMessageFromBank.AutoSize = true;
            this.labelMessageFromBank.Location = new System.Drawing.Point(127, 267);
            this.labelMessageFromBank.Name = "labelMessageFromBank";
            this.labelMessageFromBank.Size = new System.Drawing.Size(65, 13);
            this.labelMessageFromBank.TabIndex = 13;
            this.labelMessageFromBank.Text = "theMessage";
            this.labelMessageFromBank.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonCheckBalance
            // 
            this.buttonCheckBalance.Location = new System.Drawing.Point(32, 48);
            this.buttonCheckBalance.Name = "buttonCheckBalance";
            this.buttonCheckBalance.Size = new System.Drawing.Size(119, 23);
            this.buttonCheckBalance.TabIndex = 14;
            this.buttonCheckBalance.Text = "Check Balance";
            this.buttonCheckBalance.UseVisualStyleBackColor = true;
            this.buttonCheckBalance.Click += new System.EventHandler(this.buttonCheckBalance_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Location = new System.Drawing.Point(32, 87);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(119, 23);
            this.buttonDeposit.TabIndex = 15;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonWithdrawal
            // 
            this.buttonWithdrawal.Location = new System.Drawing.Point(32, 132);
            this.buttonWithdrawal.Name = "buttonWithdrawal";
            this.buttonWithdrawal.Size = new System.Drawing.Size(119, 23);
            this.buttonWithdrawal.TabIndex = 16;
            this.buttonWithdrawal.Text = "Withdrawal";
            this.buttonWithdrawal.UseVisualStyleBackColor = true;
            this.buttonWithdrawal.Click += new System.EventHandler(this.buttonWithdrawal_Click);
            // 
            // textBoxCheckBalance
            // 
            this.textBoxCheckBalance.Location = new System.Drawing.Point(172, 50);
            this.textBoxCheckBalance.Name = "textBoxCheckBalance";
            this.textBoxCheckBalance.Size = new System.Drawing.Size(100, 20);
            this.textBoxCheckBalance.TabIndex = 17;
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(172, 92);
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeposit.TabIndex = 18;
            // 
            // textBoxWithdrawal
            // 
            this.textBoxWithdrawal.Location = new System.Drawing.Point(172, 137);
            this.textBoxWithdrawal.Name = "textBoxWithdrawal";
            this.textBoxWithdrawal.Size = new System.Drawing.Size(100, 20);
            this.textBoxWithdrawal.TabIndex = 19;
            // 
            // groupBoxSession
            // 
            this.groupBoxSession.Controls.Add(this.buttonCheckBalance);
            this.groupBoxSession.Controls.Add(this.textBoxWithdrawal);
            this.groupBoxSession.Controls.Add(this.buttonDeposit);
            this.groupBoxSession.Controls.Add(this.textBoxDeposit);
            this.groupBoxSession.Controls.Add(this.buttonWithdrawal);
            this.groupBoxSession.Controls.Add(this.textBoxCheckBalance);
            this.groupBoxSession.Location = new System.Drawing.Point(17, 294);
            this.groupBoxSession.Name = "groupBoxSession";
            this.groupBoxSession.Size = new System.Drawing.Size(388, 225);
            this.groupBoxSession.TabIndex = 20;
            this.groupBoxSession.TabStop = false;
            this.groupBoxSession.Text = "Session";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 560);
            this.Controls.Add(this.groupBoxSession);
            this.Controls.Add(this.labelMessageFromBank);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTheSalt);
            this.Controls.Add(this.labelSalt);
            this.Controls.Add(this.labelHashedPassword);
            this.Controls.Add(this.labelHash);
            this.Controls.Add(this.buttonSalt);
            this.Controls.Add(this.buttonEnterPassword);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.buttonEnterUserName);
            this.Controls.Add(this.label1);
            this.Name = "UserForm";
            this.Text = "Alice";
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.groupBoxSession.ResumeLayout(false);
            this.groupBoxSession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonSalt;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.Button buttonEnterUserName;
        private System.Windows.Forms.Button buttonEnterPassword;
        private System.Windows.Forms.Label labelHash;
        private System.Windows.Forms.Label labelHashedPassword;
        private System.Windows.Forms.Label labelSalt;
        private System.Windows.Forms.Label labelTheSalt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMessageFromBank;
        private System.Windows.Forms.Button buttonCheckBalance;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdrawal;
        private System.Windows.Forms.TextBox textBoxCheckBalance;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.TextBox textBoxWithdrawal;
        private System.Windows.Forms.GroupBox groupBoxSession;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
/**
 * Created by Sean Steben
 * Userform provides funtionalities to send information to InfoPassed from to simulate a user's front end interaction 
 * with a bank
 */
namespace BankStream
{
    public partial class UserForm : Form
    {
        private InfoPassedForm referenceToInfoPassed;
        byte[] key;
        

        const string USERNAME = "Sean5", PASSWORD = "I<3Security";
        string salt = "", hashedPass = "", unHashedPass = "";
        string userNonce ="userNonce1" , bobNonce= "bobNonce2";

        //used to send in username and pass or hash
        string[] authenticationArray = new string[3];

        //index 0 is salt, index 1 is password
        string[] passArray = new string[] {"",""};

        bool isHashed = false, isSalted = false, loggedIn = false;
        public UserForm()
        {
            InitializeComponent();
        }
        //not used
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //not used
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalt_Click(object sender, EventArgs e)
        {
            if(isSalted)
            {
                labelSalt.Visible = false;
                labelTheSalt.Visible = false;
                salt = "";
                isSalted = false;
                passArray[0] = "";
                buttonSalt.Text = "Salt";
            }
            else
            {
                buttonSalt.Text = "Un-Salt";
                isSalted = true;
                labelSalt.Visible = true;
                labelTheSalt.Visible = true;
                //if password being sent is correct send a salt so the bank will recognize the hash
                if(textBoxPassword.Text == PASSWORD)
                {
                    salt = "IamSalted!";
                }
                else//if password is incorrect generate random salt so bank will not recognize hash
                {
                    Random rand = new Random();
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < 9; i++)
                    {
                        builder.Append(rand.Next(10));
                    }
                    salt = builder.ToString();
                    
                }
                passArray[0] = salt;
                labelTheSalt.Text = salt;
                

            }
        }

        //Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter a Username and a Password", "BankStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                authenticationArray[0] = textBoxUserName.Text.ToLower();
                //check if password is hashed
                if(isHashed)
                {
                    authenticationArray[1] = hashedPass;
                }
                else
                {
                    authenticationArray[1] = textBoxPassword.Text;
                }
                //userNonce = LFSR.GenerateNonce();
                InfoPassedForm infoPassed = new InfoPassedForm(authenticationArray, this);

                infoPassed.Show();
                referenceToInfoPassed = infoPassed;

            }

        }

        private void buttonEnterUserName_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = USERNAME;
        }

        //not used
        private void groupBoxSignIn_Enter(object sender, EventArgs e)
        {

        }
        //DepositButton
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxDeposit.Text == "" || !double.TryParse(textBoxDeposit.Text, out double result))
            {
                MessageBox.Show("Please Enter a Valid Number", "BankStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                byte[] plainText = Encoding.UTF8.GetBytes("D" + result.ToString());
                byte[] keySteam = LFSR.Encrypt(plainText, key);
                referenceToInfoPassed.ReceiveStreamAndSendToBank(keySteam);

            }

        }
        
        private void buttonCheckBalance_Click(object sender, EventArgs e)
        {
            //string keyString = bobsNonce + userNonce;
            
            key = Encoding.UTF8.GetBytes("heresAKey");
            
            byte[] plainText = Encoding.UTF8.GetBytes("CB");
            
            byte[] keyStream = LFSR.Encrypt(plainText, key);
            referenceToInfoPassed.ReceiveStreamAndSendToBank(keyStream);
            //byte[] encryptedStream = LFSR.Encrypt(plainText, key);
            
            

        }

        private void buttonWithdrawal_Click(object sender, EventArgs e)
        {
            if (textBoxWithdrawal.Text == "" || !double.TryParse(textBoxWithdrawal.Text, out double result))
            {
                MessageBox.Show("Please Enter a Valid Number", "BankStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                byte[] plainText = Encoding.UTF8.GetBytes("W" + result.ToString());
                byte[] keySteam = LFSR.Encrypt(plainText, key);
                referenceToInfoPassed.ReceiveStreamAndSendToBank(keySteam);
                

            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnterPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = PASSWORD;
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter a Password", "BankStream", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isHashed)//if button is pressed while password is hashed reset for user
            {
                labelHash.Visible = false;
                labelHashedPassword.Visible = false;
                isHashed = false;
                hashedPass = "";
                buttonHash.Text = "Hash";
                passArray[1] = textBoxPassword.Text;
            }
            else//if button is pressed and password is not already hashed
            {
                isHashed = true;

                passArray[1] = textBoxPassword.Text;
                SHA256 ShaHash = SHA256.Create();
                string inputString = passArray[0] + passArray[1];

                byte[] inputInBytes = Encoding.UTF8.GetBytes(inputString);//encoding allows conversion of string to bytes
                byte[] outputInBytes = ShaHash.ComputeHash(inputInBytes);
                hashedPass = BitConverter.ToString(outputInBytes).Replace("-", "");

                labelHashedPassword.Text = hashedPass;

                labelHashedPassword.Visible = true;
                labelHash.Visible = true;
                buttonHash.Text = "Un-Hash";
            }
        }
        public void ReceiveData(string message)
        {
            if(double.TryParse(message, out double result))
            {
                textBoxCheckBalance.Text = result.ToString("C2");
                labelMessageFromBank.Text = "Check Balance Completed";
            }
            else
                labelMessageFromBank.Text = message;
            
        }
        
       public void ReceiveDepositConfirmation(byte[] stream)
        {
            byte[] outputInBytes = LFSR.Decrypt(stream, key);
            string theMessage = Encoding.UTF8.GetString(outputInBytes);
            labelMessageFromBank.Text = theMessage;
        }
        public void ReceiveCheckBalance(byte[] stream, string message)
        {
            labelMessageFromBank.Text = message;

            byte[] outputInBytes = LFSR.Decrypt(stream, key);
            string theBalance = Encoding.UTF8.GetString(outputInBytes);

            //double balance = double.Parse(theBalance);
            textBoxCheckBalance.Text = theBalance.ToString();
                
            //textBoxCheckBalance.Text = theBalance.ToString("C2");
        }
        //currently not used
        public void ReceiveData_Nonce(string message,string nonce)
        {
            labelMessageFromBank.Text = message;
           
            
        }
    }
}

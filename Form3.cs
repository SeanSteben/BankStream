using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Created by Sean Steben
 * BankForm has funtions to recieve information, alter saving information and send back to infopassed form
 * CURRENTLY INFORMATION IS SENT BACK IN PLAIN TEXT. INTENTIONS WERE FOR INFORMATION TO BE SENT ENCYTPED
 */
namespace BankStream
{
    public partial class bankForm : Form
    {
        private string userName = "sean5", hashedSaltedPass = "3CDFD381257A4A50F76423D4A47BA572EF95D98B841A9FED3CE463F63B46FB82";
        private double balance = 1000;
        private string[] credentials;
        private InfoPassedForm referenceToInfoForm;//needed to bank can call recieve funtions
        private int bobsNonce, userNonce;
        byte[] key;
        
        public bankForm(string[] arr, InfoPassedForm callingForm)
        {
            InitializeComponent();
            credentials = arr;
            this.referenceToInfoForm =  callingForm;
            
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            sleep(1);
            textBoxBank.Text = "Checking credentials...";
            sleep(1);
            if (credentials[0] != userName || credentials[1] != hashedSaltedPass)
            {
                textBoxBank.Text = "Incorrect Login. \n  Sending error message back...";
                sendData("Incorrect Username and/or password");
                this.Close();
            }
            else
            {
                textBoxBank.Text = "Correct credentials \n Sean is now logged in";
                //generate hash of random number to send a return nonce
               // bobsNonce = LFSR.GenerateNonce();
                sendData("Welcome! What would you like to do?");
                int keyString = userNonce - bobsNonce;
                key = Encoding.UTF8.GetBytes("heresAKey");
            }
            
        }
        /*private void sendDataWithNonce(string message, string nonce)
        {
            referenceToUserForm.ReceiveData_Nonce(message,nonce);
        }*/
        private void sendData(string message)
        {
            referenceToInfoForm.ReceiveAndSendToUser(message);
        }
        public void receiveRequest(byte[] keyStream)
        {
            byte[] decryptedRequest = LFSR.Decrypt(keyStream, key);
            string decryptedInString = Encoding.UTF8.GetString(decryptedRequest);
            
            textBoxBank.Text = "Recieving request: " + decryptedInString;
            sleep(1);
            //if check balance
            if(decryptedInString == "CB")
            {
                string message = balance.ToString();
                referenceToInfoForm.ReceiveAndSendToUser(message);
                /*COMMENTED OUT BECAUSE GOING BACK STRUGGLES
                string balanceString = balance.ToString();
                byte[] balanceInBytes = Encoding.UTF8.GetBytes(balanceString);
                byte[] keySteam = LFSR.Encrypt(balanceInBytes, key);
                referenceToInfoForm.ReceiveAndSendToUser(keyStream, "Check Balance Complete");
                */
            }
            //if deposit
            if (decryptedInString[0] == 'D')
            {
                double toDeposit = double.Parse(decryptedInString.Substring(1));

                balance += toDeposit;
                referenceToInfoForm.ReceiveAndSendToUser("Deposit Complete");

                /*COMMENTED OUT BECAUSE CURRENTLY DOES NOT WORK GOING BACK TO USER
                double toDeposit = double.Parse(decryptedInString.Substring(1));
                balance += toDeposit;
                textBoxBank.Text = "New Balance: " + balance.ToString();
                string message = "Deposit Complete";
                byte[] messageinBytes = Encoding.UTF8.GetBytes(message);
                byte[] depKeyStream = LFSR.Encrypt(messageinBytes,key);
                referenceToInfoForm.ReceiveAndSendToUser(depKeyStream);
                */


            }
            //if withdrawal
            if(decryptedInString[0] == 'W')
            {
                double toWithdrawal = double.Parse(decryptedInString.Substring(1));
                if(balance < toWithdrawal)
                {
                    referenceToInfoForm.ReceiveAndSendToUser("Insufficient Funds");
                    return;
                }
                else
                {
                    balance -= toWithdrawal;
                    referenceToInfoForm.ReceiveAndSendToUser("Withdrawal Complete");
                }

                /*CODE THAT I DID NOT HAVE TIME TO MAKE WORK
                string message = "Deposit Complete";
                byte[] messageinBytes = Encoding.UTF8.GetBytes(message);
                byte[] depKeyStream = LFSR.Encrypt(messageinBytes, key);
                referenceToInfoForm.ReceiveAndSendToUser(depKeyStream);
                */


            }
           
        }

        

        private void sleep(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

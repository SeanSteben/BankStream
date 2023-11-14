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
 * InfoPassed from  is a middleman between user and bank form. Each function records and diplays information
 * being passed then sending to required destination
 */
namespace BankStream
{
    public partial class InfoPassedForm : Form
    {
        bankForm referencetoBobsBank;
        UserForm referencetoUser;
        public InfoPassedForm(string[] arr, UserForm reference)
        {
            InitializeComponent();
            referencetoUser = reference;//keep this reference to the user to send back
            textBoxInfoPassed.Text = "---->>>    " + arr[0] + " " + arr[1];
            bankForm bobBank = new bankForm(arr, this);
            bobBank.Show();
            referencetoBobsBank = bobBank;
        }
        public void ReceiveStreamAndSendToBank(byte[] stream)
        {
            textBoxInfoPassed.Text += "\n ---->>>    " +  stream.ToString();
            referencetoBobsBank.receiveRequest(stream);
        }
        public void ReceiveAndSendToUser(string message)
        {
            textBoxInfoPassed.Text += "\n <<<----    " + message;
            referencetoUser.ReceiveData(message);
        }
        public void ReceiveAndSendToUser(byte[] stream)
        {
            textBoxInfoPassed.Text += "\n <<<----    " + stream.ToString();
            referencetoUser.ReceiveDepositConfirmation(stream);
        }
        public void ReceiveAndSendToUser(byte[] stream, string message)
        {
            textBoxInfoPassed.Text += "\n <<<----     " + message + stream.ToString();
            referencetoUser.ReceiveCheckBalance(stream, message);
        }



        //NOT USED
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

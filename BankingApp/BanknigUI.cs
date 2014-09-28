using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class BanknigUI : Form
    {
        public BanknigUI()
        {
            InitializeComponent();
        }

         Account anAccount;

        private void ShowErrorMes()
        {
            MessageBox.Show(@"Please create an account first!");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
                anAccount= new Account();
                anAccount.Number=accountNoTextBox.Text;
                anAccount.Name= customerNameTextBox.Text;
               
                MessageBox.Show(anAccount.Name + @", Your Account Has Created!");
                createButton.Enabled = false;
                accountNoTextBox.Text = string.Empty;
                customerNameTextBox.Text = string.Empty;
          
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            
            
            if (anAccount != null)
            {
                anAccount.Deposite(Convert.ToDouble(amountTextBox.Text));
                MessageBox.Show(@"Your Diposite amount is: " + amountTextBox.Text + @" Taka");
                amountTextBox.Text = string.Empty;
            }
            else
            {
                ShowErrorMes();
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

            if (anAccount != null)
            {
                anAccount.Withdraw(Convert.ToDouble(amountTextBox.Text));
                MessageBox.Show(@"Your Withdrawal amount is: " + amountTextBox.Text + @" Taka");
                amountTextBox.Text = string.Empty;
            }
            else
            {
                ShowErrorMes();
            }
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                MessageBox.Show(anAccount.Name + @", your account number: " + anAccount.Number + @" and it's balance: " + anAccount.Balance + @"Taka");
            }
            else
            {
                ShowErrorMes();
            }
           
        }

        
    }
}

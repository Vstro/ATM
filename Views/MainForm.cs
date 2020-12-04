using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Services;
using ATM.Entities;

namespace ATM
{
    public partial class MainForm : Form
    {
        private Card Card { get; set; }

        public MainForm(Card card, String cardType)
        {
            InitializeComponent();
            this.CardTypeLabel.Text = cardType;
            Card = card;
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            this.BalanceLabel.Text = $"Баланс: {AccountServices.GetBalance(Card)} р.";
        }

        private void CardReturnButton_Click(object sender, EventArgs e)
        {
            this.OwnedForms[0].Show();
            this.RemoveOwnedForm(OwnedForms[0]);
            this.Close();
        }

        private void GetCashButton_Click(object sender, EventArgs e)
        {
            GetCashForm getCashForm = new GetCashForm(Card);
            getCashForm.AddOwnedForm(this);
            this.Hide();
            getCashForm.Show();
        }
    }
}

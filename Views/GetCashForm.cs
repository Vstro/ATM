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
    public partial class GetCashForm : Form
    {
        private Card Card { get; set; }

        public GetCashForm(Card card)
        {
            InitializeComponent();
            Card = card;
            UpdateAvailableBanknotes();
        }

        private void UpdateAvailableBanknotes()
        {
            try
            {
                this.AvailableBanknotesLabel.Text = $"Купюры в наличии: {BanknoteServices.GetStringRepresentation(BanknoteServices.GetAvailableBanknotes())}";
            }
            catch (ServiceException se)
            {
                this.AvailableBanknotesLabel.Text = se.Message;
                MessageBox.Show(se.Message);
            }
        }

        private void CashSumTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox source = (TextBox)sender;
            CardServices.CorrectNumericTextBox(source);
            if (source.Text.Equals("") || decimal.Parse(source.Text) <= AccountServices.GetBalance(Card))
            {
                this.OutOfMoneyLabel.Visible = false;
            }
            else
            {
                this.OutOfMoneyLabel.Visible = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.OwnedForms[0].Show();
            this.RemoveOwnedForm(OwnedForms[0]);
            this.Close();
        }

        private void GetCashButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputDataNotEmpty();
                decimal cashSum = decimal.Parse(CashSumTextBox.Text);
                BanknoteServices.CheckCashAcceptability(cashSum);
                AccountServices.WithdrawFromAccount(Card, cashSum);
                Banknote[] receivingBanknotes = BanknoteServices.CollectCash(cashSum);
                UpdateAvailableBanknotes();
                BanknoteServices.GiveCash(cashSum, receivingBanknotes);
            }
            catch (ServiceException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void CheckInputDataNotEmpty()
        {
            if (CashSumTextBox.Text.Equals(""))
            {
                throw new ServiceException("Введите сумму для выдачи!");
            }
        }
    }
}

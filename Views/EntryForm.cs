using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Services;
using ATM.Entities;

namespace ATM
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            // temporary hardcode
            //DAO.CardDAO.AddCards(new Card(378282246310005UL, 3782), new Card(5555555555554444UL, 5555), new Card(4111111111111111UL, 4111));
            //DAO.AccountDAO.AddAccounts(new Account(378282246310005UL, 100), new Account(5555555555554444UL, 2000));
            //DAO.BanknoteDAO.ReplaceBanknotes(new Banknote(200, 1), new Banknote(100, 5), new Banknote(50, 10), new Banknote(10, 20), new Banknote(5, 40));
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInputDataNotEmpty();
                Card card = new Card(ulong.Parse(CardNumberTextBox.Text), short.Parse(PincodeTextBox.Text));
                String cardType = CardServices.ValidateCard(card);
                MainForm mainForm = new MainForm(card, cardType);
                mainForm.AddOwnedForm(this);
                this.Hide();
                mainForm.Show();
            }
            catch (ServiceException se)
            {
                MessageBox.Show(se.Message);
                return;
            }
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            CardServices.CorrectNumericTextBox((TextBox)sender);
        }

        private void PincodeTextBox_TextChanged(object sender, EventArgs e)
        {
            CardServices.CorrectNumericTextBox((TextBox)sender);
        }

        private void CheckInputDataNotEmpty()
        {
            if (CardNumberTextBox.Text.Equals("") || PincodeTextBox.Text.Equals(""))
            {
                throw new ServiceException("Введите номер карты и пин-код!");
            }
        }
    }
}

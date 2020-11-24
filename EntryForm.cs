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

namespace ATM
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            ulong cardNumber;
            if (!ulong.TryParse(CardNumberTextBox.Text, out cardNumber))
            {
                // Диалоговое/модальное окно "Некорректный номер карты: используйте только 13-.. десятичных цифр!"
                return;
            }
            String cardType = Card.CheckNumber(cardNumber);
            if (cardType.Equals("INVALID"))
            {
                // Диалоговое/модальное окно "Некорректный номер карты: введённый номер не принадлежит ни одному известному банку!"
                return;
            }

            using (StreamReader file = new StreamReader("Data/Pincodes"))
            {
                while (!file.EndOfStream)
                {
                    String[] cardInfo = file.ReadLine().Split(' ');
                    if (ulong.Parse(cardInfo[0]) == cardNumber && cardInfo[1].Equals(PincodeTextBox.Text))
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.CardTypeLabel.Text = cardType;
                        mainForm.Show();
                        this.Hide();
                        return;
                    }
                }
            }           
        }

        private void CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

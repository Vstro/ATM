using ATM.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATM.Entities;

namespace ATM.Services
{
    static class CardServices
    {
        public static Dictionary<ulong, byte> FailedTries { get; set; } = new Dictionary<ulong, byte>();

        public static String ValidateCard(Card card)
        { 
            String cardType = CardLogic.CheckNumber(card.Number);
            if (cardType.Equals("INVALID"))
            {
                throw new ServiceException("Введённый номер не соответствует ни одному известному стандарту!");
            }
            if (CardLogic.IsBlocked(card))
            {
                throw new ServiceException("Данная карта заблокирована!");
            }
            if (!CardLogic.CheckPincode(card))
            {
                if (FailedTries.TryGetValue(card.Number, out byte failCounter))
                {
                    if (failCounter == 2)
                    {
                        CardLogic.BlockCard(card);
                        throw new ServiceException("Слишком много неудачных попыток - карта заблокирована!");
                    }
                    FailedTries[card.Number]++;
                }
                else
                {
                    FailedTries.Add(card.Number, 1);
                }
                throw new ServiceException("Неправильный пин-код!");
            }
            return cardType;
        }

        public static void CorrectNumericTextBox(TextBox textBox)
        {
            StringBuilder correctedText = new StringBuilder();
            foreach (char c in textBox.Text)
            {
                if (CardLogic.IsNumeric(c))
                {
                    correctedText.Append(c);
                }
            }
            textBox.Text = correctedText.ToString();
        }
    }
}

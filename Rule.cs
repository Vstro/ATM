using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Rule
    {
        private byte[] digitAmount;
        private uint[] firstDigits;
        private byte[] checkSumReminder;
        private string creditorName;

        public Rule(string rule)
        {
            string[] rules = rule.Split(' ');

            string[] digitAmountRules = rules[0].Split('/');
            digitAmount = new byte[digitAmountRules.Length];
            for (int i = 0; i < digitAmountRules.Length; i++)
            {
                byte.TryParse(digitAmountRules[i], out this.digitAmount[i]);
            }

            string[] firstDigitsRules = rules[1].Split('/');
            firstDigits = new uint[firstDigitsRules.Length];
            for (int i = 0; i < firstDigitsRules.Length; i++)
            {
                uint.TryParse(firstDigitsRules[i], out this.firstDigits[i]);
            }

            string[] checkSumReminderRules = rules[2].Split('/');
            checkSumReminder = new byte[checkSumReminderRules.Length];
            for (int i = 0; i < checkSumReminderRules.Length; i++)
            {
                byte.TryParse(checkSumReminderRules[i], out this.checkSumReminder[i]);
            }

            this.creditorName = rules[3];
        }

        public byte[] getDigitAmount()
        {
            return digitAmount;
        }

        public uint[] getFirstDigits()
        {
            return firstDigits;
        }

        public byte[] getCheckSumReminder()
        {
            return checkSumReminder;
        }

        public string getCreditorName()
        {
            return creditorName;
        }
    }
}

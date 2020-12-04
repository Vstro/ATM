using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Rule
    {
        public byte[] DigitAmount { get; set; }
        public uint[] FirstDigits { get; set; }
        public byte[] CheckSumReminder { get; set; }
        public String CreditorName { get; set; }

        public Rule(String rule)
        {
            String[] rules = rule.Split(' ');

            String[] digitAmountRules = rules[0].Split('/');
            DigitAmount = new byte[digitAmountRules.Length];
            for (int i = 0; i < digitAmountRules.Length; i++)
            {
                byte.TryParse(digitAmountRules[i], out this.DigitAmount[i]);
            }

            String[] firstDigitsRules = rules[1].Split('/');
            FirstDigits = new uint[firstDigitsRules.Length];
            for (int i = 0; i < firstDigitsRules.Length; i++)
            {
                uint.TryParse(firstDigitsRules[i], out this.FirstDigits[i]);
            }

            String[] checkSumReminderRules = rules[2].Split('/');
            CheckSumReminder = new byte[checkSumReminderRules.Length];
            for (int i = 0; i < checkSumReminderRules.Length; i++)
            {
                byte.TryParse(checkSumReminderRules[i], out this.CheckSumReminder[i]);
            }

            this.CreditorName = rules[3];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.DAO;
using ATM.Entities;

namespace ATM.Logic
{
    static class CardLogic
    {
        public static void BlockCard(Card card)
        {
            CardDAO.AddBlockedCard(card);
        }

        public static bool IsBlocked(Card card)
        {
            foreach (Card c in CardDAO.GetBlockedCards())
            {
                if (card.Number == c.Number)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPincode(Card card)
        {
            foreach (Card c in CardDAO.GetCards())
            {
                if (card.Equals(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static String CheckNumber(ulong num)
        {
            Rule[] rules = RuleDAO.GetRules();
            foreach (Rule rule in rules)
            {
                uint[] validFirstDigits = rule.FirstDigits;
                bool matched = false;

                for (int i = 0; i < validFirstDigits.Length; i++)
                {
                    if (FirstDigits(num, DigitsAmount(validFirstDigits[i])) == validFirstDigits[i])
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    continue;
                }

                byte[] validDigitsAmounts = rule.DigitAmount;
                matched = false;

                for (int i = 0; i < validDigitsAmounts.Length; i++)
                {
                    if (DigitsAmount(num) == validDigitsAmounts[i])
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    continue;
                }

                byte[] validCheckSumReminders = rule.CheckSumReminder;
                matched = false;

                for (int i = 0; i < validCheckSumReminders.Length; i++)
                {
                    if (ChecksumReminder(num) == validCheckSumReminders[i])
                    {
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    continue;
                }

                return rule.CreditorName;
            }

            return "INVALID";
        }

        private static ulong FirstDigits(ulong num, byte digitAmount)
        {
            if (num < Math.Pow(10, digitAmount))
            {
                return num;
            }
            else
            {
                return FirstDigits(num / 10, digitAmount);
            }
        }

        private static byte ChecksumReminder(ulong num)
        {
            int oddDigitsSum = 0; // Эти цифры просто суммируем
            int evenDigitsSum = 0; // Эти умножаем на 2, а затем суммируем их ЦИФРЫ
            bool isIterationOdd = true;

            while (num > 0)
            {
                if (isIterationOdd)
                {
                    oddDigitsSum += (int)(num % 10);
                }
                else
                {
                    evenDigitsSum += DigitsSum((int)(num % 10) * 2);
                }

                isIterationOdd = !isIterationOdd;
                num /= 10;
            }

            return (byte)((oddDigitsSum + evenDigitsSum) % 10);
        }

        private static int DigitsSum(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        private static byte DigitsAmount(ulong num)
        {
            byte count = 0;
            while (num > 0)
            {
                num /= 10;
                count++;
            }

            return count;
        }

        public static bool IsNumeric(char ch)
        {
            return (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4' ||
                ch == '5' || ch == '6' || ch == '7' || ch == '8' || ch == '9');
        }
    }
}

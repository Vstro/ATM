using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Card
    {
        private static Rule[] rules = null;
        public ulong Number { get; set; }
        public short Pincode { get; private set; }

        public static void UpdateRules(string dirName)
        {
            string[] fileNames = Directory.GetFiles(dirName);
            rules = new Rule[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                using (FileStream file = File.OpenRead($"{fileNames[i]}"))
                {
                    // Читаем весь файл в массив байтов
                    byte[] array = new byte[file.Length];
                    file.Read(array, 0, array.Length);

                    // Декодируем байты в строку
                    string textRule = System.Text.Encoding.Default.GetString(array);

                    // Добавляем правило на основе прочитанного
                    rules[i] = new Rule(textRule);
                }
            }           
        }

        public static string CheckNumber(ulong num)
        {
            if (Card.rules == null)
            {
                UpdateRules("Rules");
            }

            foreach (Rule rule in rules)
            {
                uint[] validFirstDigits = rule.getFirstDigits();
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

                byte[] validDigitsAmounts = rule.getDigitAmount();
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

                byte[] validCheckSumReminders = rule.getCheckSumReminder();
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

                return rule.getCreditorName();
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
    }
}
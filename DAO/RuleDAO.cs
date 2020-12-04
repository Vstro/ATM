using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;

namespace ATM.DAO
{
    static class RuleDAO
    {
        private static String DataDirName { get; set; } = "Data";

        public static Rule[] GetRules(String rulesDirName = "Rules")
        {
            String[] fileNames = Directory.GetFiles(DataDirName + "\\" + rulesDirName);
            Rule[] rules = new Rule[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                using (FileStream file = File.OpenRead($"{fileNames[i]}"))
                {
                    // Читаем весь файл в массив байтов
                    byte[] array = new byte[file.Length];
                    file.Read(array, 0, array.Length);

                    // Декодируем байты в строку
                    String textRule = System.Text.Encoding.Default.GetString(array);

                    // Добавляем правило на основе прочитанного
                    rules[i] = new Rule(textRule);
                }
            }
            return rules;
        }
    }
}

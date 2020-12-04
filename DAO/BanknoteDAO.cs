using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;

namespace ATM.DAO
{
    static class BanknoteDAO
    {
        private static String DataDirName { get; set; } = "Data";
        private static String BanknotesFileName { get; set; } = "Banknotes";

        public static Banknote[] GetBanknotes()
        {
            String path = DataDirName + "\\" + BanknotesFileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Banknote[] banknotes;
                if (fs.Length == 0)
                {
                    banknotes = new Banknote[0];
                }
                else
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Object result = formatter.Deserialize(fs);
                    if (result is Banknote)
                    {
                        banknotes = new Banknote[] { (Banknote)result };
                    }
                    else
                    {
                        banknotes = (Banknote[])result;
                    }
                }
                return banknotes;
            }
        }

        public static void ReplaceBanknotes(params Banknote[] banknotes)
        {
            String path = DataDirName + "\\" + BanknotesFileName;
            using (FileStream fs = new FileStream(path, FileMode.Truncate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, banknotes);
            }
        }
    }
}

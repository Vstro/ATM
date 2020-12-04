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
    static class AccountDAO
    {
        private static String DataDirName { get; set; } = "Data";
        private static String AccountsFileName { get; set; } = "Accounts";

        public static Account[] GetAccounts()
        {
            String path = DataDirName + "\\" + AccountsFileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Account[] accounts;
                if (fs.Length == 0)
                {
                    accounts = new Account[0];
                }
                else
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Object result = formatter.Deserialize(fs);
                    if (result is Account)
                    {
                        accounts = new Account[] { (Account)result };
                    }
                    else
                    {
                        accounts = (Account[])result;
                    }
                }
                return accounts;
            }
        }

        public static void AddAccounts(params Account[] accounts)
        {
            String path = DataDirName + "\\" + AccountsFileName;
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, accounts);
            }
        }

        public static void ReplaceAccounts(params Account[] accounts)
        {
            String path = DataDirName + "\\" + AccountsFileName;
            using (FileStream fs = new FileStream(path, FileMode.Truncate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, accounts);
            }
        }
    }
}

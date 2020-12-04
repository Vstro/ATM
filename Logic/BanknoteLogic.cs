using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;
using ATM.DAO;

namespace ATM.Logic
{
    static class BanknoteLogic
    {
        public static Banknote[] GetAvailableBanknotes()
        {
            return BanknoteDAO.GetBanknotes();
        }

        public static void UpdateBanknotes(Banknote[] banknotes)
        {
            BanknoteDAO.ReplaceBanknotes(banknotes);
        }

        public static bool TryCollectCashSum(decimal cashSum, out Banknote[] banknotes)
        {
            banknotes = BanknoteDAO.GetBanknotes().OrderByDescending(b => b.Value).ToArray();
            int i = 0;
            while (i < banknotes.Length && cashSum > 0)
            {
                if (banknotes[i].Value > cashSum || banknotes[i].Amount == 0)
                {
                    i++;
                }
                else
                {
                    cashSum -= banknotes[i].Value;
                    banknotes[i].Amount--;
                }
            }
            if (cashSum == 0)
            {
                return true;
            }
            return false;
        }

        public static Banknote[] GetDifference(Banknote[] allBanknotes, Banknote[] subtractingBanknotes)
        {
            allBanknotes = allBanknotes.OrderByDescending(b => b.Value).ToArray();
            subtractingBanknotes = subtractingBanknotes.OrderByDescending(b => b.Value).ToArray();
            Banknote[] difference = new Banknote[allBanknotes.Length];
            for (int i = 0; i < allBanknotes.Length; i++)
            {
                difference[i] = new Banknote(allBanknotes[i].Value, 
                    allBanknotes[i].Amount - subtractingBanknotes[i].Amount);
            }
            return difference;
        }
    }
}

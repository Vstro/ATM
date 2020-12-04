using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;
using ATM.Logic;

namespace ATM.Services
{
    static class BanknoteServices
    {
        public static Banknote[] GetAvailableBanknotes()
        {
            Banknote[] banknotes = BanknoteLogic.GetAvailableBanknotes();
            if (banknotes.Length == 0)
            {
                throw new ServiceException("Закончились купюры!");
            }
            return banknotes.Where(b => b.Amount > 0).ToArray();
        }

        public static void CheckCashAcceptability(decimal cashSum)
        {
            if (cashSum == 0)
            {
                throw new ServiceException("Введите ненулевую сумму!");
            }
            if (!BanknoteLogic.TryCollectCashSum(cashSum, out Banknote[] banknotes))
            {
                throw new ServiceException("Запрошенную сумму невозможно выдать имеющимися купюрами!");
            }
        }

        public static String GetStringRepresentation(Banknote[] banknotes)
        {
            StringBuilder text = new StringBuilder("");
            Banknote[] values = banknotes.OrderByDescending(b => b.Value).Where(b => b.Amount > 0).ToArray();
            foreach (Banknote banknote in values)
            {
                text.Append($"{banknote.Value}x{banknote.Amount}, ");
            }
            return text.Remove(text.Length - 2, 2).ToString();
        }

        public static Banknote[] CollectCash(decimal cashSum)
        {
            Banknote[] banknotes = BanknoteLogic.GetAvailableBanknotes();
            BanknoteLogic.TryCollectCashSum(cashSum, out Banknote[] remainingBanknotes);
            BanknoteLogic.UpdateBanknotes(remainingBanknotes);
            return BanknoteLogic.GetDifference(banknotes, remainingBanknotes);
        }

        public static void GiveCash(decimal cashSum, Banknote[] banknotes)
        {
            throw new ServiceException($"Получите ваши {cashSum} р.: {GetStringRepresentation(banknotes)}");
        }
    }
}

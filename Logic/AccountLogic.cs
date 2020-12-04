using ATM.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;

namespace ATM.Logic
{
    static class AccountLogic
    {
        public static Account GetAccount(Card card)
        {
            foreach (Account acc in AccountDAO.GetAccounts())
            {
                if (card.Number == acc.Number)
                {
                    return acc;
                }
            }
            return new Account(0, 0);
        }

        public static void Withdraw(Card card, decimal cashSum)
        {
            Account[] accounts = AccountDAO.GetAccounts();
            accounts.Single(a => a.Number == card.Number).Balance -= cashSum;
            AccountDAO.ReplaceAccounts(accounts);
        }
    }
}

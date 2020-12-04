using ATM.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Entities;

namespace ATM.Services
{
    static class AccountServices
    {
        public static decimal GetBalance(Card card)
        {
            return AccountLogic.GetAccount(card).Balance;
        }

        public static void WithdrawFromAccount(Card card, decimal cashSum)
        {
            if (AccountLogic.GetAccount(card).Number == 0)
            {
                throw new ServiceException("Целевой счёт не найден!");
            }
            if (cashSum > GetBalance(card))
            {
                throw new ServiceException("Недостаточно средств!");
            }
            AccountLogic.Withdraw(card, cashSum);
        }
    }
}

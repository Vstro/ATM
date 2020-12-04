using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Entities
{
    [Serializable]
    public class Account
    {
        public ulong Number { get; set; }
        public decimal Balance { get; set; }

        public Account(ulong number, decimal balance)
        {
            Number = number;
            Balance = balance;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Account anotherAccount))
            {
                return false;
            }
            return Number == anotherAccount.Number && Balance == anotherAccount.Balance;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return 31 * Number.GetHashCode() + Balance.GetHashCode();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Entities
{
    [Serializable]
    class Banknote
    {
        public ushort Value { get; set; }
        public ulong Amount { get; set; }

        public Banknote(ushort value, ulong amount)
        {
            Value = value;
            Amount = amount;
        }
    }
}

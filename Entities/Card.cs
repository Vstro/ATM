using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Entities
{
    [Serializable]
    public class Card
    {
        public ulong Number { get; set; }
        public short Pincode { get; set; }

        public Card(ulong number, short pincode)
        {
            Number = number;
            Pincode = pincode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Card anotherCard))
            {
                return false;
            }
            return Number == anotherCard.Number && Pincode == anotherCard.Pincode;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return 31 * Number.GetHashCode() + Pincode.GetHashCode();
            }
        }
    }
}
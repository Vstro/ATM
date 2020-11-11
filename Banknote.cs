using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Banknote : ISerializable
    {
        public ushort Value { get; private set; }
        public ulong Amount { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}

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
    static class CardDAO
    {
        private static String DataDirName { get; set; } = "Data";
        private static String CardsFileName { get; set; } = "Cards";
        private static String BlockedCardsFileName { get; set; } = "BlockedCards";

        public static Card[] GetCards()
        {
            String path = DataDirName + "\\" + CardsFileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Card[] cards;
                if (fs.Length == 0)
                {
                     cards = new Card[0];
                }
                else
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Object result = formatter.Deserialize(fs);
                    if (result is Card)
                    {
                        cards = new Card[] { (Card)result };
                    }
                    else
                    {
                        cards = (Card[])result;
                    }
                }              
                return cards;
            }
        }

        public static void AddCards(params Card[] cards)
        {
            String path = DataDirName + "\\" + CardsFileName;
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, cards);
            }
        }

        public static Card[] GetBlockedCards()
        {
            String path = DataDirName + "\\" + BlockedCardsFileName;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Card[] cards;
                if (fs.Length == 0)
                {
                    cards = new Card[0];
                }
                else
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Object result = formatter.Deserialize(fs);
                    if (result is Card)
                    {
                        cards = new Card[] {(Card)result};
                    }
                    else
                    {
                        cards = (Card[])result;
                    }
                }
                return cards;
            }
        }

        public static void AddBlockedCard(Card card)
        {
            String path = DataDirName + "\\" + BlockedCardsFileName;
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, card);
            }
        }
    }
}

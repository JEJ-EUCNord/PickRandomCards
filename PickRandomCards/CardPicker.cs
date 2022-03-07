using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            String[] pickedCards = new String[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            throw new NotImplementedException();
        }

        private static string RandomValue()
        {
            throw new NotImplementedException();
        }
    }
}

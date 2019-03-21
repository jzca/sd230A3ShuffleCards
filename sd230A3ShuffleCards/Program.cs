using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd230A3ShuffleCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var myHandler = new Handler();

            myHandler.ShowFirstTimeAllCards();
            myHandler.ShuffleCardsFirstTime();
            myHandler.ShowAfterShufflingAllCards();
            myHandler.DealOneCard();
            myHandler.DealOneCard();
            myHandler.DeckCounterAfterShuffling();
            myHandler.ShuffleCardsAfter1stTime();
            myHandler.ShowAfterShufflingAllCards();
            //myHandler.ShowAllCard();
            //myHandler.ShuffleCards();
            //myHandler.ShowAllCard();
            //myHandler.DealOneCard();
            //myHandler.ShowAllCard();
            //myHandler.DealAllCard();
            //Console.WriteLine($"Num of Card Left: {myHandler.DeckCounter}");

            // Important!!
            Console.ReadLine();

        }
    }
}

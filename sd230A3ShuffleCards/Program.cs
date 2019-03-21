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
            myHandler.ShuffleCards();
            myHandler.ShowAfterShufflingAllCards();
            myHandler.ShuffleCards();
            myHandler.ShowAfterShufflingAllCards();
            //myHandler.ShowAfterShufflingAllCards();
            //myHandler.ShowAfterShufflingAllCards();


            //myHandler.ShowFirstTimeAllCards();
            //myHandler.ShuffleCards();
            //myHandler.ShowAfterShufflingAllCards();
            //myHandler.DealOneCard();
            //myHandler.DealOneCard();
            ////myHandler.DeckCounterAfterShuffling();
            //myHandler.ShuffleCards();
            //myHandler.ShowAfterShufflingAllCards();
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

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

            //You have these method;
            myHandler.ShowAllCards();
            myHandler.ShuffleCards();
            myHandler.ShowAllCards();
            myHandler.DealOneCard();
            myHandler.DeckCounter();
            myHandler.ShuffleCards();
            myHandler.ShowAllCards();
            myHandler.DealAllCard();
            myHandler.DeckCounter();

            

            //                myHandler.ShowFirstTimeAllCards();
            //myHandler.ShuffleCards();
            //myHandler.ShowAfterShufflingAllCards();
            //myHandler.DealOneCard();
            //myHandler.DeckCounterAfterShuffling();
            //myHandler.DealAllCard();
            //myHandler.DeckCounterAfterShuffling();
            //myHandler.ShuffleCards();
            //myHandler.ShowAfterShufflingAllCards();
            //myHandler.DealOneCard();
            //myHandler.DeckCounterAfterShuffling();


            //myHandler.DealOneCard();
            //myHandler.DealOneCard();
            //myHandler.DealOneCard();




            // Important!!
            Console.ReadLine();

        }
    }
}

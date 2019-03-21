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

            // You have these 5 method;
                //ShowAllCards();
                //ShuffleCards();
                //DealOneCard();
                //DealAllCard();
                //DeckCounter();

            myHandler.ShowAllCards();
            myHandler.ShuffleCards();
            myHandler.ShowAllCards();
            myHandler.DealOneCard(); // rm one
            myHandler.DealOneCard(); // rm another one
            myHandler.DeckCounter(); // 50
            myHandler.ShuffleCards();
            myHandler.ShowAllCards();
            myHandler.DealAllCard();
            myHandler.DeckCounter(); // 0



            // Important!!
            Console.ReadLine();

        }
    }
}

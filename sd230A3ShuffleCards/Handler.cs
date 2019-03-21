using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd230A3ShuffleCards
{
    public class Handler
    {
        private List<int> SubPrimaryDeck { get; set; }
        private List<int> SubMediumDeck { get; set; }
        private List<int> MainDeck { get; set; }
        private Random RdmPicker { get; set; }
        private int OneBefore { get; set; }
        private int OneAfter { get; set; }
        private int Picker { get; set; }
        private int CounterForShuffle { get; set; }
        private int CounterForShow { get; set; }
        private int CounterForDeckAmt { get; set; }

        public Handler()
        {
            RdmPicker = new Random();
            SubPrimaryDeck = new List<int>
            {
               1, 2, 3, 4, 5, 6, 7, 8,
               9, 10, 11, 12, 13, 14, 15,
               16, 17, 18, 19, 20, 21, 22,
               23, 24, 25, 26, 27, 28, 29,
               30, 31, 32, 33, 34, 35, 36,
               37, 38, 39, 40, 41, 42, 43,
               44, 45, 46, 47, 48, 49, 50,
               51, 52
            };
            SubMediumDeck = new List<int>();
            MainDeck = new List<int>();
            CounterForShuffle = 0;
            CounterForShow = 0;
        }

        public void ShuffleCards()
        {
            if (CounterForShuffle == 0)
            {
                CounterForShuffle++;
                SubPrimaryDeck = new List<int>
                {
                   1, 2, 3, 4, 5, 6, 7, 8,
                   9, 10, 11, 12, 13, 14, 15,
                   16, 17, 18, 19, 20, 21, 22,
                   23, 24, 25, 26, 27, 28, 29,
                   30, 31, 32, 33, 34, 35, 36,
                   37, 38, 39, 40, 41, 42, 43,
                   44, 45, 46, 47, 48, 49, 50,
                   51, 52
                };
            }
            else
            {
                MainDeck.ForEach(p => SubPrimaryDeck.Add(p));
                MainDeck.Clear();
                SubMediumDeck.Clear();
            }



            while (SubPrimaryDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, SubPrimaryDeck.Count);
                OneBefore = Picker - 1;
                OneAfter = Picker + 1;

                if (OneBefore >= 0)
                {
                    SubMediumDeck.Add(SubPrimaryDeck[OneBefore]);
                    SubPrimaryDeck.RemoveAt(OneBefore);
                }
                else
                {
                    SinglePicker();
                }

                if (OneAfter < SubPrimaryDeck.Count)
                {
                    SubMediumDeck.Add(SubPrimaryDeck[OneAfter]);
                    SubPrimaryDeck.RemoveAt(OneAfter);
                }
                else
                {
                    SinglePicker();
                }

                ShuffleAgain();

            }
            Console.WriteLine($"**** Shuffled *******");

        }

        private void SinglePicker()
        {
            if (Picker < SubPrimaryDeck.Count)
            {
                SubMediumDeck.Add(SubPrimaryDeck[Picker]);
                SubPrimaryDeck.RemoveAt(Picker);
            }
        }

        private void ShuffleAgain()
        {
            while (SubMediumDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, SubMediumDeck.Count);
                if (Picker < SubMediumDeck.Count)
                {
                    MainDeck.Add(SubMediumDeck[Picker]);
                    SubMediumDeck.RemoveAt(Picker);
                }
            }
        }

        public void DealOneCard()
        {
            if(CounterForShuffle != 0)
            {
                Console.WriteLine($"You dealt: {MainDeck[0]}");
                MainDeck.RemoveAt(0);
            }
            else
            {
                Console.WriteLine($"Firstly, you have to shuffle the deck!");
            }


        }

        public void DealAllCard()
        {
            MainDeck.Clear();
            SubPrimaryDeck.Clear();
            Console.WriteLine("No cards left any more");
            Console.WriteLine("You may quit the app now");
        }

        public void ShowAllCards()
        {
            if (CounterForShow == 0)
            {
                CounterForShow++;
                Console.WriteLine($"***** Welcome! You have *******");
                SubPrimaryDeck.ForEach(p => Console.WriteLine($"{p}"));
                Console.WriteLine($"***** The End *******");
            }
            else
            {
                Console.WriteLine($"***** You Still have *******");
                MainDeck.ForEach(f => Console.WriteLine($"{f}"));
                Console.WriteLine($"***** The End *******");
            }


        }


        public void DeckCounter()
        {
            if (CounterForDeckAmt == 0)
            {
                CounterForDeckAmt++;
                Console.WriteLine($"Num of Card Left: {SubPrimaryDeck.Count}");
            }
            else
            {
                Console.WriteLine($"Num of Card Left: {MainDeck.Count}");
            }
        }

        //// In Case

        //public void DeckCounterAfterShuffling()
        //{
        //    Console.WriteLine($"Num of Card Left: {MainDeck.Count}");
        //}

        //public void ShowFirstTimeAllCards()
        //{

        //    Console.WriteLine($"***** Welcome! You have *******");
        //    SubPrimaryDeck.ForEach(p => Console.WriteLine($"{p}"));
        //    Console.WriteLine($"***** The End *******");
        //}

        //public void ShowAfterShufflingAllCards()
        //{

        //    Console.WriteLine($"***** Afer Shuffling, You Still have *******");
        //    MainDeck.ForEach(f => Console.WriteLine($"{f}"));
        //    Console.WriteLine($"***** The End *******");

        //}


    }
}

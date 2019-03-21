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
        //private int CounterForShuffle { get; set; }
        //private int CounterForShow { get; set; }

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
            //CounterForShuffle = 0;
            //CounterForShow = 0;
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

        public void ShuffleCardsFirstTime()
        {

            while (SubPrimaryDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, SubPrimaryDeck.Count);
                OneBefore = Picker - 1;
                OneAfter = Picker + 1;

                if (OneBefore > 0)
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
            Console.WriteLine("**** Shuffled *******");
        }


        public void ShuffleCardsAfter1stTime()
        {

            while (MainDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, MainDeck.Count);
                OneBefore = Picker - 1;
                OneAfter = Picker + 1;

                if (OneBefore > 0)
                {
                    SubMediumDeck.Add(MainDeck[OneBefore]);
                    MainDeck.RemoveAt(OneBefore);
                }
                else
                {
                    if (Picker < MainDeck.Count)
                    {
                        SubMediumDeck.Add(MainDeck[Picker]);
                        MainDeck.RemoveAt(Picker);
                    }
                }

                if (OneAfter < MainDeck.Count)
                {
                    SubMediumDeck.Add(MainDeck[OneAfter]);
                    MainDeck.RemoveAt(OneAfter);
                }
                else
                {
                    if (Picker < MainDeck.Count)
                    {
                        SubMediumDeck.Add(MainDeck[Picker]);
                        MainDeck.RemoveAt(Picker);
                    }
                }

                ShuffleAgain();

            }
            Console.WriteLine("**** Shuffled *******");
        }

        public void DealOneCard()
        {
            Console.WriteLine($"You dealt: {MainDeck[0]}");
            MainDeck.RemoveAt(0);

        }

        public void DealAllCard()
        {
            MainDeck = new List<int>();
            SubPrimaryDeck = new List<int>();
            Console.WriteLine("No cards left any more");
            Console.WriteLine("You may quit the app now");
        }

        public void ShowFirstTimeAllCards()
        {

            Console.WriteLine($"***** Welcome! You have *******");
            SubPrimaryDeck.ForEach(p => Console.WriteLine($"{p}"));
            Console.WriteLine($"***** The End *******");
        }

        public void ShowAfterShufflingAllCards()
        {

            Console.WriteLine($"***** Afer Shuffling, You Still have *******");
            MainDeck.ForEach(f => Console.WriteLine($"{f}"));
            Console.WriteLine($"***** The End *******");

        }

        public void DeckCounterAfterShuffling()
        {
            Console.WriteLine($"Num of Card Left: {MainDeck.Count}");
        }


    }
}

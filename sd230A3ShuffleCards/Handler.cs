using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sd230A3ShuffleCards
{
    public class Handler
    {
        public List<int> PrimaryDeck { get; set; }
        public List<int> MediumDeck { get; set; }
        public List<int> FinalDeck { get; set; }
        public Random RdmPicker { get; set; }
        public int OneBefore { get; set; }
        public int OneAfter { get; set; }
        public int Picker { get; set; }

        public Handler()
        {
            RdmPicker = new Random();
            PrimaryDeck = new List<int>
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
            MediumDeck = new List<int>();
            FinalDeck = new List<int>();
        }

        public void ShuffleCards()
        {
            PrimaryDeck = new List<int>
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


            while (PrimaryDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, PrimaryDeck.Count);
                OneBefore = Picker - 1;
                OneAfter = Picker + 1;

                if (OneBefore > 0)
                {
                    MediumDeck.Add(PrimaryDeck[OneBefore]);
                    PrimaryDeck.RemoveAt(OneBefore);
                }
                else
                {
                    SinglePicker();
                }

                if (OneAfter < PrimaryDeck.Count)
                {
                    MediumDeck.Add(PrimaryDeck[OneAfter]);
                    PrimaryDeck.RemoveAt(OneAfter);
                }
                else
                {
                    SinglePicker();
                }

                ShuffleAgain();

            }
            Console.WriteLine("Shuffled");
        }

        public void SinglePicker()
        {
            if (Picker < PrimaryDeck.Count)
            {
                MediumDeck.Add(PrimaryDeck[Picker]);
                PrimaryDeck.RemoveAt(Picker);
            }
        }

        public void ShuffleAgain()
        {
            while (MediumDeck.Count != 0)
            {
                Picker = RdmPicker.Next(0, MediumDeck.Count);
                if (Picker < MediumDeck.Count)
                {
                    FinalDeck.Add(MediumDeck[Picker]);
                    MediumDeck.RemoveAt(Picker);
                }
            }
        }

        public void DealOneCard(string input)
        {
            int inputInUse;
            bool successfullyParsed = int.TryParse(input, out inputInUse);
            if (successfullyParsed &&
                inputInUse < FinalDeck.Count && inputInUse >= 1)
            {
                Console.WriteLine(FinalDeck[inputInUse - 1]);
                FinalDeck.RemoveAt(inputInUse - 1);
            }

        }

        public void DealAllCard()
        {
            FinalDeck = new List<int>();
            PrimaryDeck = new List<int>();
            Console.WriteLine("No cards left any more");

        }

        public void ShowAllCard()
        {

            Console.WriteLine($"You have");
            int counter = 0;
            if (counter == 0)
            {
                counter++;
                foreach (var b in PrimaryDeck)
                {
                    Console.WriteLine($"{b}");
                }
            }
            else
            {
                foreach (var b in FinalDeck)
                {
                    Console.WriteLine($"{b}");
                }
            }
            Console.WriteLine($"The End");
        }

        public void OpenMeun()
        {
            Console.WriteLine("Choose following options");
            Console.WriteLine("1. Show all cards");
            Console.WriteLine("2. Shuffle cards");
            Console.WriteLine("3. Deal a card");
            Console.WriteLine("4. Deal all card");
            Console.WriteLine("0. Exit");
            var userInput = Console.ReadLine();

            while (userInput != "0")
            {
                if (userInput == "1")
                {
                    ShowAllCard();
                    Console.WriteLine("2. Shuffle cards");
                    Console.WriteLine("3. Deal a card");
                    Console.WriteLine("4. Deal all card");
                    Console.WriteLine("0. Exit");
                    Console.ReadKey();
                }
                else if (userInput == "2")
                {
                    ShuffleCards();
                    Console.ReadKey();
                }
                else if (userInput == "4")
                {
                    DealAllCard();
                    ShowAllCard();
                    Console.ReadKey();
                }
            }




        }


    }
}

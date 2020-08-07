using System;

namespace Quiz06
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] deck = new int[52];
            for (int cards = 0; cards <= deck.Length - 1; cards++)
            {
                deck[cards] = cards;
            }

            for (int i = 0; i <= 51; i++)
            {
                cardValue(deck[i]);
            }

            Console.WriteLine("=========================================================");
            Console.WriteLine("Dealing from new deck...");
            makeHand();

        }
        static void cardValue(int value)
        {
            if (value < 0)
                Console.WriteLine("Card number too low to be valid");
            if (value > 52)
                Console.WriteLine("Card number too high to be valid");

            int cardRank = value % 13;
            switch (cardRank)
            {
                case 0:
                    Console.Write("Two ");
                    break;
                case 1:
                    Console.Write("Three ");
                    break;
                case 2:
                    Console.Write("Four ");
                    break;
                case 3:
                    Console.Write("Five ");
                    break;
                case 4:
                    Console.Write("Six ");
                    break;
                case 5:
                    Console.Write("Seven ");
                    break;
                case 6:
                    Console.Write("Eight ");
                    break;
                case 7:
                    Console.Write("Nine ");
                    break;
                case 8:
                    Console.Write("Ten ");
                    break;
                case 9:
                    Console.Write("Jack ");
                    break;
                case 10:
                    Console.Write("Queen ");
                    break;
                case 11:
                    Console.Write("King ");
                    break;
                case 12:
                    Console.Write("Ace ");
                    break;
            }

            int valueSuit = value / 13;
            switch (valueSuit)
            {
                case (0):
                    Console.WriteLine("Of Clubs");
                    break;
                case (1):
                    Console.WriteLine("Of Diamonds");
                    break;
                case (2):
                    Console.WriteLine("Of Hearts");
                    break;
                case (3):
                    Console.WriteLine("Of Spades");
                    break;
                default:
                    break;
            }


        }
        static void makeHand()
        {
            Random random = new Random();
            int[] cardArray = new int[52];
            int rndNum = 0;

            for (int suits = 0; suits < 13; suits++)
            {
                for (int value = 0; value < 4; value++)
                {
                    do
                    {
                        rndNum = random.Next(51);
                        cardArray[rndNum] = rndNum;

                    } while (cardArray[rndNum] >= 100);

                    switch (value)
                    {
                        case 0:
                            Console.Write("~~North~~ ");
                            break;
                        case 1:
                            Console.Write("~~East~~ ");
                            break;
                        case 2:
                            Console.Write("~~South~~ ");
                            break;
                        case 3:
                            Console.Write("~~West~~ ");
                            break;
                        default:
                            break;
                    }
                    cardValue(rndNum);
                    cardArray[rndNum] = 101;
                }
            }
        }
    }
}

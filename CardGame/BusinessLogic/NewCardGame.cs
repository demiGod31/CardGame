using System;
using CardGame.Interfaces;
using static CardGame.Constants.CardConstants;

namespace CardGame.BusinessLogic
{
    class NewCardGame : INewCardGame
    {
        // This function contains the logic to start the game and it's game flow.
        public void StartGame()
        {
            int selectedOption;
            Console.WriteLine("Welcome to this Simple Card Game! Please select an Option.");
            IDeckOperations deckOperations = new DeckOperations();
            DisplayGameOptions();

            while (true)
            {
                try
                {
                    selectedOption = int.Parse(Console.ReadLine());
                    switch (selectedOption)
                    {
                        case (int)GameOptions.Play:
                            var topCard = deckOperations.GetTopCard();
                            Console.WriteLine($"Card Played is {(Rank)(topCard.Value)} of {topCard.Face}");
                            Console.WriteLine($"Number of Cards remaining in hand - {deckOperations.GetCount()}");
                            break;
                        case (int)GameOptions.Restart:
                            Console.Clear();
                            deckOperations.ResetDeck();
                            Console.WriteLine("New Game Started! Please select an Option.");
                            DisplayGameOptions();
                            break;
                        case (int)GameOptions.Shuffle:
                            deckOperations.ShuffleDeck();
                            Console.WriteLine("Card deck shuffled successfully!");
                            break;
                        case (int)GameOptions.Exit:
                            deckOperations.ClearDeck();
                            Console.WriteLine("Thanks for playing!");
                            Environment.Exit(0);
                            return;
                        default:
                            Console.WriteLine("Please choose a game option from the list.");
                            DisplayGameOptions();
                            break;
                    }
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Please enter only numbers from the list.");
                    DisplayGameOptions();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        //This function displays all the game options from the constants.
        public void DisplayGameOptions()
        {
            foreach (GameOptions gameOption in Enum.GetValues(typeof(GameOptions)))
            {
                Console.WriteLine($"{(int)gameOption}.  {gameOption}");
            }
        }
    }
}

using CardGame.BusinessLogic;
using CardGame.Interfaces;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the object of card game.
            INewCardGame cardGame = new NewCardGame();
            cardGame.StartGame(); 
        }
    }
}

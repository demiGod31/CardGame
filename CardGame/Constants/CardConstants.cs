using System;

namespace CardGame.Constants
{
    //This class stores all the constants needed for the card game.
    class CardConstants
    {
        readonly public static String[] Suit = {
            "Spades",
            "Hearts",
            "Clubs",
            "Diamond" };
        public enum Rank
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        };

        public enum GameOptions
        {
            Play = 1,
            Shuffle = 2,
            Restart = 3,
            Exit = 4

        };
    }
}

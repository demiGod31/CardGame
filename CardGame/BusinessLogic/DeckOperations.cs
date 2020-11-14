using System;
using System.Collections.Generic;
using System.Linq;
using CardGame.BusinessEntities;
using CardGame.Constants;
using CardGame.Interfaces;
using static CardGame.Constants.CardConstants;

namespace CardGame.BusinessLogic
{
    //This class contains all the functions for the implementation of deck operations.
    class DeckOperations : IDeckOperations
    {
        private Stack<Card> _cardDeck;
        public DeckOperations()
        {
            _cardDeck = new Stack<Card>();
            InitializeDeck();
        }

        //This function pops the top card from the card deck.
        public Card GetTopCard()
        {
            if (_cardDeck.Count == 0)
            {
                throw new Exception("No cards remaining in hand to play, press 3 to restart the game.");
            }
            return _cardDeck.Pop();
        }

        //This function shuffles the deck of cards.
        public void ShuffleDeck()
        {
            if (_cardDeck.Count == 0)
            {
                throw new Exception("No cards remaining in hand to shuffle, please restart the game!");
            }
            Random randomNumber = new Random();
            _cardDeck = new Stack<Card>(_cardDeck.OrderBy(card => randomNumber.Next()));
        }

        //This function returns the number of items in the deck.
        public int GetCount()
        {
            return _cardDeck.Count;
        }

        //This function resets the card deck by clearing and recreating the deck.
        public void ResetDeck()
        {
            ClearDeck();
            InitializeDeck();
        }
        public void ClearDeck()
        {
            _cardDeck.Clear();
        }

        //This function creates a card deck
        public void CreateCardDeck()
        {
            foreach (string suitName in CardConstants.Suit)
            {
                foreach (Rank cardRank in Enum.GetValues(typeof(Rank)))
                {
                    _cardDeck.Push(new Card() { Face = suitName, Value = (int)cardRank });
                }
            }
        }
        //This function initializes the deck with new set of cards.
        private void InitializeDeck()
        {
            CreateCardDeck();
            ShuffleDeck();
        }
    }
}

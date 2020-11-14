using CardGame.BusinessEntities;

namespace CardGame.Interfaces
{
    // This is the interface for all deck operations.
    interface IDeckOperations
    {
        Card GetTopCard();
        void ShuffleDeck();
        int GetCount();
        void ResetDeck();
        void ClearDeck();
    }
}

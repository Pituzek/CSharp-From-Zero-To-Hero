using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Gambling;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    public class GameComponentsTests
    {
        /// <summary>
        ///     Checks if exception is thrown, when provided index is bigger than current deck size
        /// </summary>
        /// <param name="index"></param>
        [Theory]
        [InlineData(2)]
        public void Deck_Draw_Validates_deck_size(int index)
        {
            //Arrange
            Deck testDeck = new Deck(CreateDeck());

            //Act
            //void Create() => testDeck.DrawAt(index);
            Action action = () => testDeck.DrawAt(index);

            //Assert
            Assert.Throws<OutOfCardsException>(action);
        }

        private static List<Card> CreateDeck()
        {
            Card AceClubs = new Card(Card.Suites.Clubs, Card.Ranks.Ace);
            Card TwoClubs = new Card(Card.Suites.Clubs, Card.Ranks.Two);
            List<Card> testDeck = new List<Card> { AceClubs, TwoClubs };
            return testDeck;
        }
    }
}

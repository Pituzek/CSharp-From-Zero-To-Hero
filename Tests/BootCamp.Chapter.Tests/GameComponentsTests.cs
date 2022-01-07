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
        ///     Check if DrawFromTop() return card from top of the stack
        /// </summary>
        [Fact]
        public void Deck_DrawFromTop_return_card_from_top_of_the_deck()
        {
            //Arrange
            List<Card> cardList =  CreateCards();
            Deck testDeck = new Deck(cardList);
            var lastIndex = cardList.Count - 1;

            //Act
            var drawCard = testDeck.DrawFromTop();

            //Assert
            Assert.Equal(cardList[lastIndex], drawCard);
        }

        [Theory]
        [MemberData(nameof(CardDeckExpectations))]
        public void Deck_DrawAt_return_card_at_given_index(Card.Suites suites, Card.Ranks ace, int index)
        {
            //Arrange
            Deck testDeck = new Deck(CreateDeck());
            var Card = new Card(suites, ace);

            //Act
            //Action action = () => testDeck.DrawAt(index);
            String action = testDeck.DrawAt(index).ToString();

            //Assert
            Assert.Equal(Card.ToString(), action);
        }

        public static IEnumerable<object[]> CardDeckExpectations
        {
            get
            {
                yield return new object[] { Card.Suites.Clubs, Card.Ranks.Ace, 0 };
                yield return new object[] { Card.Suites.Clubs, Card.Ranks.Two, 1 };
            }
        }

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

        private static List<Card> CreateCards()
        {
            Card AceClubs = new Card(Card.Suites.Clubs, Card.Ranks.Ace);
            Card TwoClubs = new Card(Card.Suites.Clubs, Card.Ranks.Two);
            Card ThreeClubs = new Card(Card.Suites.Clubs, Card.Ranks.Three);
            Card QueenClubs = new Card(Card.Suites.Clubs, Card.Ranks.Queen);
            Card KingDiamonds = new Card(Card.Suites.Diamonds, Card.Ranks.King);
            List<Card> cardList = new List<Card> { AceClubs, TwoClubs, ThreeClubs, QueenClubs, KingDiamonds };
            return cardList;
        }

    }
}

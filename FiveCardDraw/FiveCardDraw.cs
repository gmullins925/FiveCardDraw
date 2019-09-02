using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardDraw
{
	class FiveCardDraw
	{
		/// <summary>
		/// Gets or sets the Cards in the Player's hands
		/// </summary>
		
		public List<Card> PlayerHand { get; set; }

		/// <summary>
		/// Gets or sets the cards in the deck
		/// </summary>
	
		public DeckOfCards deckOfCards { get; set; }

		/// <summary>
		/// Creates a new game
		/// </summary>

		public FiveCardDraw()
		{
			deckOfCards = new DeckOfCards();
			deckOfCards.Shuffle();
			PlayerHand = new List<Card>();
		}

		/// <summary>
		/// Play a hand of 5 card draw
		/// </summary>

		public void PlayRound()
		{
			//deal five cards to player
			for (int n = 0; n < 5; n++)
			{
				PlayerHand.Add(deckOfCards.Deal());
			}
			ShowPlayerHand();
		}

		/// <summary>
		/// Play a hand of 5 card draw
		/// </summary>

		public void ShowPlayerHand()
		{
			for (int n = 0; n < PlayerHand.Count; n++)
			{
				Console.WriteLine("Card # " + (n + 1) + ": " + PlayerHand[n]);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardDraw
{
	class DeckOfCards
	{
		public List<Card> Deck { get; set; }
		private const int NUMBER_OF_CARDS = 52;

		public DeckOfCards()
		{
			//all faces and suits in two seperate arrays with card vLUES
			string[] faces = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
			string[] suits = { "♠", "♣", "♥", "♦" };
			int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			//new deck
			Deck = new List<Card>();

			//populate entire deck array with card objects
			for (int count = 0; count < NUMBER_OF_CARDS; count++)
			{
				Deck.Add(new Card(faces[count % 13], suits[count / 13], value[count % 13]));
			}
		}

		public void Shuffle()
		{
			Random randNum = new Random();
			int nRand;
			Card temp;

			//swap every card in the deck with another random card
			for (int n = 0; n < Deck.Count; n++)
			{
				nRand = randNum.Next(1, Deck.Count);
				temp = Deck[nRand];
				Deck[n] = Deck[nRand];
				Deck[nRand] = temp;
			}
		}

		/// <summary>
		/// Returns top card in Deck and removes that card from Deck
		/// </summary>
		/// <returns>/<returns></returns>

		public Card Deal()
		{
			//deal top card and remove from deck
			Card temp = Deck[0];
			Deck.RemoveAt(0);
			return temp;
		}
	}
}



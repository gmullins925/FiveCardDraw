using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example_VS
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Card myCard = new Card("Q", "♠", 14);
			Console.WriteLine(myCard.Value);
			myCard.Value = 10;
			Console.WriteLine(myCard.Value);
			Console.ReadLine();
			*/

			Console.OutputEncoding = System.Text.Encoding.Unicode;
			DeckOfCards myDeck = new DeckOfCards();

			//cycle thru deck
			foreach (Card card in myDeck.Deck)
			{
				Console.WriteLine(card.Value + card.Suit);
			}
			Console.ReadLine();
		}



	}
}

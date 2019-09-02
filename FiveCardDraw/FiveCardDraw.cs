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

		public bool[] Discard;

		/// <summary>
		/// Play a hand of 5 card draw
		/// </summary>

		public void PlayRound()
		{
			Discard = new bool[5] { false, false, false, false, false };
			string userChoice;
			int discardMe = 0;

			//deal five cards to player
			for (int n = 0; n < 5; n++)
			{
				PlayerHand.Add(deckOfCards.Deal());
			}

			//discard loop
			do
			{
				ShowPlayerHand();

				Console.WriteLine("Type the number of the card in you hand and hit Enter to toggle between Keep/Discard.");
				Console.WriteLine("Type 'D' to finalize discard.");
				userChoice = Console.ReadLine();

				//input validation loop
				while (userChoice != "D" && !int.TryParse(userChoice, out discardMe))
				{
					Console.WriteLine("Invalid choice. Try Again: ");
					userChoice = Console.ReadLine();
				}

				//toggle element using ternary operator

				if (userChoice != "D" && discardMe > 0 && discardMe < 6)
				{
					Discard[discardMe - 1] = Discard[discardMe - 1] == true ? false : true;
				}
			} while (userChoice != "D");

			FinalizeDiscard();
			ShowPlayerHand();

		}//end PlayRound()

		private void FinalizeDiscard()
		{
			for (int n = 0; n < PlayerHand.Count; n++)
			{
				//if card marked to be discarded, replace with new card
				if (Discard[n])
				{
					deckOfCards.Deck.Add(PlayerHand[n]);
					PlayerHand[n] = deckOfCards.Deal();
				}
			}

			//reset Discard bool array
			Discard = new bool[5] { false, false, false, false, false };
		}


		/// <summary>
		/// Play a hand of 5 card draw
		/// </summary>

		public void ShowPlayerHand()
		{
			for (int n = 0; n < PlayerHand.Count; n++)
			{
				if (!Discard[n])
					Console.WriteLine("Card # " + (n + 1) + ": " + PlayerHand[n]);
				else
					Console.WriteLine("Card # " + (n + 1) + ": " + PlayerHand[n] + "<---Discard");
		
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to Nothing like Blackjack");
            Console.WriteLine();

            // create and shuffle a deck
            Deck deck;
            deck = new Deck();
            deck.Shuffle();
            // deck.Print();
            Console.WriteLine();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)

            Card player1card1 = deck.TakeTopCard();
            Card player2card1 = deck.TakeTopCard();
            Card player3card1 = deck.TakeTopCard();

            Card player1card2 = deck.TakeTopCard();
            Card player2card2 = deck.TakeTopCard();
            Card player3card2 = deck.TakeTopCard();

            // flip all the cards over
            player1card1.FlipOver();
            player2card1.FlipOver();
            player3card1.FlipOver();

            player1card2.FlipOver();
            player2card2.FlipOver();
            player3card2.FlipOver();


            // print the cards for player 1
            Console.WriteLine("The cards of Player1 are: " + player1card1 + " and " + player1card2);
            Console.WriteLine();

            // print the cards for player 2
            Console.WriteLine("The cards of Player1 are: " + player2card1 + " and " + player2card2);
            Console.WriteLine();

            // print the cards for player 3
            Console.WriteLine("The cards of Player1 are: " + player3card1 + " and " + player3card2);
            Console.WriteLine();

        }
    }
}

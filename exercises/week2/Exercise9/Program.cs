﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck;
            deck = new Deck();
            // deck.Print();
            // Console.WriteLine();

            // tell the deck to shuffle and print itself
            deck.Shuffle();
            deck.Print();
            Console.WriteLine();

            // take the top card from the deck and print the card rank and suit
            Card card0 = deck.TakeTopCard();

            Console.WriteLine("First card is: " + card0.Rank + " of " + card0.Suit);

            // take the top card from the deck and print the card rank and suit
            Card card1 = deck.TakeTopCard();

            Console.WriteLine("Second card is: " + card1.Rank + " of " + card1.Suit);
            Console.WriteLine();
        }
    }
}

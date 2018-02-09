using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Wars
{
    class Program
    {
        const int maxCounter = 1000000;
        static void Main(string[] args)
        {
            var player1cards = new Queue <string>(Console.ReadLine().Split());
            var player2cards = new Queue<string>(Console.ReadLine().Split());

            int turnCounter = 0;
            bool gameOver = false;
            while (turnCounter < maxCounter && player1cards.Count > 0 && player2cards.Count > 0 && !gameOver)
            {
                turnCounter++;
                var firstCard = player1cards.Dequeue();
                var secondCard = player2cards.Dequeue();
                if (GetNumber(firstCard) > GetNumber(secondCard))
                {
                    player1cards.Enqueue(firstCard);
                    player1cards.Enqueue(secondCard);
                }
                else if (GetNumber(firstCard) < GetNumber(secondCard))
                {
                    player2cards.Enqueue(secondCard);
                    player2cards.Enqueue(firstCard);
                }
                else
                {
                    var cardsPlayedByNow = new List<string> { firstCard, secondCard };

                    while (!gameOver)
                    {
                        if (player1cards.Count >= 3 && player2cards.Count >= 3)
                        {
                            int player1Sum = 0; int player2Sum = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                var firstCardPlayed = player1cards.Dequeue();
                                var secondCardPlayed = player2cards.Dequeue();
                                player1Sum += GetChar(firstCardPlayed);
                                player2Sum += GetChar(secondCardPlayed);

                                cardsPlayedByNow.Add(firstCardPlayed);
                                cardsPlayedByNow.Add(secondCardPlayed);
                                if (player1Sum > player2Sum)
                                {
                                    AddCardsToWinner(cardsPlayedByNow, player1cards);
                                    break;
                                }
                                else if(player1Sum < player2Sum)
                                {
                                    AddCardsToWinner(cardsPlayedByNow, player2cards);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }
                    }
                }
            }
            var result = String.Empty;
            if (player1cards.Count == player2cards.Count)
            {
                result = "Draw";
            }
            else if(player1cards.Count > player2cards.Count)
            {
                result = "First player wins";
            }
            else
            {
                result = "Second player wins";
            }
            Console.WriteLine($"{result} after {turnCounter} turns");
        }

        private static void AddCardsToWinner(List<string> cardsPlayedByNow, Queue<string> player1cards)
        {
            foreach (var card in cardsPlayedByNow.OrderByDescending(card => GetNumber(card)).ThenByDescending(
                card => GetChar(card)))
            {
                player1cards.Enqueue(card);
            }
        }

        public static int GetNumber(string card)
        {
            return int.Parse(card.Substring(0, card.Length - 1));
        }

        public static int GetChar(string card)
        {
            return card[card.Length - 1];
        }
    }
}

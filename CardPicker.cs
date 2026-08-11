using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        /// <summary>
        /// Об'єкт класу Random, використовуваний в методах
        /// RandomValue і RandomSuit для генерації випадкових чисел.
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Обирає декілька випадкових карт та повертає їх.
        /// </summary>
        /// <param name="numberOfCards">Кількість карт, які потрібно вибрати.</param>
        /// <returns>Масив стрічок з назвами карт.</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        /// <summary>
        /// Генерує випадковий номінал для карти.
        /// </summary>
        /// <returns>Стрічка з номіналом карти.</returns>
        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }

        /// <summary>
        /// Генерує випадкову масть для карти.
        /// </summary>
        /// <returns>Стрічка з мастю карти.</returns>
        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }
    }
}

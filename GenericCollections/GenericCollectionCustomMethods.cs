using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public static class GenericCollectionCustomMethods
    {
        //23.Обзор коллекций
        public static double GetMaxScore(List<double> scores)
        {
            double maxScore = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > maxScore) maxScore = scores[i];
            }
            return maxScore;
        }
        public static List<double> CalculatePricesWithMarkup(List<double> prices, double markup)
        {
            List<double> pricesWithMarkup = new List<double>(prices.Count);
            for (int i = 0; i < prices.Count; i++)
            {
                pricesWithMarkup.Add(prices[i] + prices[i] * markup / 100);
            }
            return pricesWithMarkup;
        }
        public static int CountUnderachievingClerks(List<double> results, double requiredSum)
        {
            int count = 0;
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] < requiredSum) count++;
            }
            return count;
        }

        public static void Print(List<double> list)
        { 
            foreach (var item in list) 
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

    }

}

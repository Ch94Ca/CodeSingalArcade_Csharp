using System;

namespace Challenge_isAdmissibleOverpayment
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = { 110, 95, 70 };
            string[] notes = { "10.0% higher than in-store", "5.0% lower than in-store", "Same as in-store" };
            Console.WriteLine(isAdmissibleOverpayment(prices, notes, 5));

            double[] pricesB = { 48, 165 };
            string[] notesB = { "20.00% lower than in-store", "10.00% higher than in-store" };
            Console.WriteLine(isAdmissibleOverpayment(pricesB, notesB, 2));
        }

        static bool isAdmissibleOverpayment(double[] prices, string[] notes, double x)
        {
            string[] auxStrArr;
            string auxStr = string.Empty;
            decimal price;
            decimal percentage;
            decimal difference;
            decimal totalDiff = 0.0M;
            int len = prices.Length;

            for (int i = 0; i < len; i++)
            {   

                if(notes[i][0] == 'S')
                {
                    difference = 0;
                    totalDiff += difference;
                    continue;
                }

                auxStrArr = notes[i].Split(' ');
                auxStr = auxStrArr[0].Substring(0, auxStrArr[0].IndexOf('%'));
                percentage = decimal.Parse(auxStr);
                price = Convert.ToDecimal(prices[i]);

                if (auxStrArr[1][0] == 'h')
                {
                    difference = price - (price / (1 + (percentage / 100)));
                }
                else
                {
                    difference = price - (price / (1 - (percentage / 100)));
                }

                totalDiff += difference;

            }

            if(totalDiff <= (decimal)x)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

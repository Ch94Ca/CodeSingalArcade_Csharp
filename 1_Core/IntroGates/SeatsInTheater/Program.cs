using System;

namespace SeatsInTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(seatsInTheater(16, 11, 5, 3));
        }

        public static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - (col - 1)) * (nRows - row);
        }
    }
}

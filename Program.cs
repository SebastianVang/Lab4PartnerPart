using System;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 0, 1 }, { 1, 2 }, { 2, 3}, { 3, 4 } };
            PrintRowSums(RowSum(arr));
        }
        /// <summary>
        /// This method checks if all elements are greater          :D
        /// than zero. If the number of rows = the number of columns
        /// and if both things are true, return true, false otherwise.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static bool isDiagonal(int[,] array)
        {
            Boolean isDiagonal = true;
            Boolean isSquare = false;

            //Check if array is empty
            if (array.Length == 0)
                isDiagonal = false;
            else
            {
                //Check if the array is square
                int rowLength = array.GetLength(0);
                int colLength = array.GetLength(1);

                if (rowLength == colLength)
                    isSquare = true;

                //Check if all elements are greater than 0
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (array[i, j] < 1)
                            isDiagonal = false;
                    }
                }
            }

            return isDiagonal & isSquare;
        }//end isDiagonal Method
        
        public static int[] RowSum(int[,] bigArr)
        {
            int[] rowSumArr = new int[bigArr.GetLength(0)];
            for (int i = 0; i < bigArr.GetLength(0); i++)
            {
                rowSumArr[i] = 0;
                for (int j = 0; j < bigArr.GetLength(1); j++)
                {
                    rowSumArr[i] += bigArr[i,j];
                }
            }
            return rowSumArr;
        }

        public static void PrintRowSums(int[] rowSumArray)
        {
            for (int i = 0; i < rowSumArray.GetLength(0); ++i)
            {
                Console.WriteLine("Sum for row " + i + ": " + rowSumArray[i] + "\n");
            }
        }
    }
}

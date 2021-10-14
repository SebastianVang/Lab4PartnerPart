using System;

namespace ConsoleApp1
{
    class Program
    {
      
       /* static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(RowSum(arr)[i]);
            }
            
        }*/
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
    }
}

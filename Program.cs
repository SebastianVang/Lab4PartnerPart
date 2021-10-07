using System;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            
        }
        /// <summary>
        /// This method checks if all the elements are greater 
        /// than zero. If the number of rows =  the number of columns
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
            {
                isDiagonal = false;
            }
            else
            {
                //Check if the array is square
                int rowLength = array.GetLength(0);
                int colLength = array.GetLength(1);

                if (rowLength == colLength)
                {
                    isSquare = true;
                }

                //Check if all elements are greater than 0
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (array[i, j] < 1)
                        {
                            isDiagonal = false;
                        }
                    }
                }
            }

            return isDiagonal & isSquare;
        }
    }
}

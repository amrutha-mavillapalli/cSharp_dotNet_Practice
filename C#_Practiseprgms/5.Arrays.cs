namespace MyPractise
{
    public class ClsArrays
    {
        public static void Arrays()
        {
            // Single-dimensional array
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Single-dimensional array:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Multi-dimensional array
            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("\nMulti-dimensional array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            Console.WriteLine("\nJagged array:");
            foreach (var arr in jaggedArray)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
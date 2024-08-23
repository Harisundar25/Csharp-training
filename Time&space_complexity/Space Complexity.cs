namespace Time_space_complexity
{
    public class Space_Complexity
    {
        /// <summary>
        /// Constant Space - O(1)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        /// <summary>
        /// Linear Space - O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CreateArray(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
            return arr;
        }
        /// <summary>
        ///  Quadratic Space - O(n^2)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i * j;
                    Console.WriteLine(matrix[i,j]);
                }
            }
            Console.ReadKey();
            return matrix;
        }

    }
}

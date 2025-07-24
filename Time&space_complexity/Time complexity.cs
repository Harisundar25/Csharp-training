namespace Time_space_complexity
{
    public class Time_complexity
    {
        /// <summary>
        /// Method represents Constant Time - O(1)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int GetFirstElement(int[] arr)
        {
            return arr[4];
        }
        /// <summary>
        /// Linear Time - O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        /// <summary>
        /// Quadratic Time - O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int CountPairs(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

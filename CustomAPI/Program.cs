namespace CustomAPI
{
    internal class Program
    {
        private static Dependencies.ExerFwAPIWrite apiRawData;

        public static void Main(string[] args)
        {
            WriteAPI.WriteFwAPIRawData(apiRawData);
        }
    }
}

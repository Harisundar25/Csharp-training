namespace OOPS
{
    internal class Phone
    {
            private string Company;
            private string Model;
            private string ReleaseDay;

            // default constructor
            public Phone()
            {
                Company = "unknown";
                Model = "unknown";
                ReleaseDay = "unknown";
            }
            // constructor with 2 arguement
            public Phone(string _Company, string _Model)
            {
                Company = _Company;
                Model = _Model;
                ReleaseDay = "unknown";
            }
            // constructor with 3 arguement
            public Phone(string _Company, string _Model, string _ReleaseDay)
            {
                Company = _Company;
                Model = _Model;
                ReleaseDay = _ReleaseDay;
            }

            public void Introduce()
            {
                Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
            }
    }
}

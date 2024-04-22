namespace OOPS
{
    internal class Phone
    {
        /*The main of this exercise is to create 3 constructors for the class Phone:
         * default constructor that sets all values to "unknown";
         * constructor that takes 2 arguments (company and model) and sets them respectively. The ReleaseDay should be set to "unknown";
         * constructor with 3 arguments (company, model, and release day);
         * Warning: You should not touch the given parts of the code! Create only 3 constructors. */

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

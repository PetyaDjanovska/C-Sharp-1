using System;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            DateTime dOB = Convert.ToDateTime(Console.ReadLine());
            DateTime present = DateTime.Today;

            TimeSpan age = present - dOB;
            int years = (int)age.TotalDays / 365;
            Console.WriteLine(years);
            Console.WriteLine(years + 10);
        }
    }
}



//using System;
//using System.Globalization;

//namespace Age
//{
//    class Age
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            DateTime dOB = DateTime.Parse(input,CultureInfo.InvariantCulture);
//            DateTime present = DateTime.Today;
//            DateTime restriction = new DateTime(2016, 12, 31);
//            int age = present.Year - dOB.Year;

//            if (dOB >= restriction)
//            {
//                Console.WriteLine("Incorrect date of birth!");
//            }
//            else
//            {
//                Console.WriteLine(age);
//                Console.WriteLine(age + 10);
//            }
//        }
//    }
//}

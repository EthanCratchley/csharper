using System;
using System.Globalization;
using System.Text;

namespace LearningSharper4
{
    public class Program
    {
        // FUNCTIONS
        // Layout:
        // <Access Specifier> <Return Type> <Method Name> (Parameters)
        // { <Body> }

        // Access Specifier determines whether the function can be called from another class
        // public : can be accessed from any class
        // private : can't be accessed from another class
        // protected : can be accessed by class and derived classes

        /*private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name?: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }*/
        /*static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }*/

        /*static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }*/

        /*public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }*/
        /*static double GetSumMore(params double[] nums)
        {
            double sum = 0;
                foreach (int i in nums)
            {
                sum += i;
            }
                return sum;
        }*/

        /*static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}",
                name, zipCode);
        }*/

        /*static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }

        static double GetSum2(double x = "1", double y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }*/

        // END OF FUNCTIONS

        static void Main(string[] args)
        {
            // String Builder:
            /* StringBuilder sb = new StringBuilder(" Random Text");
             StringBuilder sb2 = new StringBuilder("More Important Stuff", 256);
             Console.WriteLine("Capacity: {0}", sb2.Capacity);
             Console.WriteLine("Length: {0}", sb2.Length);
             sb2.AppendLine("\nMore important text");
             CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
             string bestCust = "Bob Smith";
             sb2.AppendFormat(enUS,"Best Customer: {0}", bestCust);
             Console.WriteLine(sb2.ToString());
             sb2.Replace("text", "characters");
             Console.WriteLine(sb2.ToString());
             sb2.Clear();
             sb2.Append("Random Text");
             Console.WriteLine(sb.Equals(sb2));
             sb2.Insert(11, "that's great");
             Console.WriteLine(sb2.ToString());
             sb2.Remove(11, 7);
             Console.WriteLine(sb2.ToString());*/

            // Functions:
            /*SayHello();*/

            /*double x = 5;
            double y = 4;
            Console.WriteLine("5 + 4 = {0}", GetSum(x, y));*/

            /*int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);*/

            /*int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0} num 2 : {1}",
                num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num1 : {0} num 2 : {1}",
                num3, num4);*/

            /*Console.WriteLine("1+2+3 = {0}",
                GetSumMore(1, 2, 3));*/

            /*PrintInfo(zipCode: 15147, name: "Derek Banans");*/

            /*Console.WriteLine("5.0 + 4.- = {0])", GetSum2(5.0, 4.5));
            Console.WriteLine("5.0 + 4.- = {0])", GetSum2("5.0", "4.5"));*/

            /*DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of the Week : {0}",
                awesomeDate.DayOfWeek);
            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("New Date : {0}",
                awesomeDate.Date);
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}",
                lunchTime.ToString());*/
        }
    }
}

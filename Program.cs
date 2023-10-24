using System;

namespace LearningSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Basic Console Commands:
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();
            //Console.WriteLine("Hello, World!");

            // Strings:
            //Console.Write("What's your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}!");

            // Data Types and Variables:
            //bool canIVote = true;

            //Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            //Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            //Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            //Console.WriteLine("Smallest Long: {0}", long.MinValue);

            //decimal decPiVal = 3.14515165626358752468734543478M;
            //decimal decBigNum = 3.00000000000000000000000000011M;
            //Console.WriteLine("DEC : PI + bigNum = {0}",
            //    decPiVal + decBigNum);

            //Console.WriteLine("Biggest Decimal: {0}", Decimal.MaxValue);

            // Doubles:
            //Console.WriteLine("Biggest Double: {0}", Double.MaxValue);
            //double dblPiVal = 3.1478643856985654;
            //double dblBigNum = 3.147864767843689734564;
            //Console.WriteLine("DBL : PI + bigNum = {0}", 
            //    dblPiVal + dblBigNum);

            // Float:
            //Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            //double fltPiVal = 3.1478643856985654;
            //double fltBigNum = 3.147864767843689734564;
            //Console.WriteLine("FLT : PI + bigNum = {0}",
            //    fltPiVal + fltBigNum);

            // Casting:                                                 
            //bool boolFromStr = bool.Parse("true");                                                    
            //int intFromStr = int.Parse("100");                                                    
            //double dblFromStr = double.Parse("1.234");                                                    

            //string strVal = dblFromStr.ToString();
            //Console.WriteLine($"Data type: {strVal.GetType()}");
            //double dblNum = 12.345;
            //Console.WriteLine($"Integer: {(int)dblNum}"); // Explicit Conversion 
            //int intNum = 10;                                                  
            //long longNum = intNum;                                            

            // Format Output:                                                   
            //Console.WriteLine("Currency: {0:c}", 23.455);                        
            //Console.WriteLine("Pad with 0s: {0:d4}", 23);
            //Console.WriteLine("3 Decimals: {0:f3}", 23.4557632457);
            //Console.WriteLine("Commas: {0:n4}", 2300000);

            //String Functions:
            //string randString = "this is a string";
            //Console.WriteLine("String Length: {0}",
            //    randString.Length);
            //Console.WriteLine("String Contains is : {0}",
            //    randString.Contains("is"));
            //Console.WriteLine("Index of is : {0}",
            //    randString.IndexOf("is"));
            //Console.WriteLine("Remove String : {0}",
            //    randString.Remove(10, 6));
            //Console.WriteLine("Insert String : {0}",
            //    randString.Insert(10, "short"));
            //Console.WriteLine("Replace String : {0}",
            //    randString.Replace("string", "sentence"));
            //Console.WriteLine("Compare Strings A to B : {0}",
            //    String.Compare("A", "B",
            //    StringComparison.OrdinalIgnoreCase)); /* Compare String and Ignore Case: 
            //                                           * < 0 : str1 preceeds str2
            //                                           * = : Zero
            //                                          * > 0 : str2 preceeds str1 */
            //Console.WriteLine("Compare A to B : {0}",
            //String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            // Check if strings are equal
            //Console.WriteLine("A = a : {0}",
            //    String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            // Add padding left
            //Console.WriteLine("Pad Left : {0}",
            //    randString.PadLeft(20, '.'));
            // Add padding right
            //Console.WriteLine("Pad Right : {0} Stuff",
            //    randString.PadRight(20, '.'));
            // Trim whitespace
            //Console.WriteLine("Trim : {0}",
            //    randString.Trim());
            // Make uppercase
            //Console.WriteLine("Uppercase : {0}",
            //    randString.ToUpper());
            // Make lowercase
            //Console.WriteLine("Lowercase : {0}",
            //    randString.ToLower());
            // Use Format to create strings
            //string newString = String.Format("{0} saw a {1} {2} in the {3}",
            //    "Paul", "rabbit", "eating", "field");
            // You can add newlines with \n and join strings with +
            //Console.Write(newString + "\n");
            // Other escape characters
            // \' \" \\ \t \a
            // Verbatim strings ignore escape characters
            //Console.WriteLine(@"Exactly What I Typed\n");
        }
    }
}
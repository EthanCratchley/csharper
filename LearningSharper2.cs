using System;

namespace LearningSharp2
{
    public class Program
    {

        // ---FUNCTIONS---

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        // ---END OF FUNCTIONS---
        static void Main(string[] args)
        {
            // Format:
            //string newString = String.Format("{0} saw {1} {2} in the {3}",
            //    "Paul", "Rabbit", "Eating", "Field");
            //Console.Write(newString + "\n");
            //Console.WriteLine(@"Exactly What I typed \n");

            // Arrays:
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            string[] customers = { "Bob", "Sally", "Sue" };
            var employees = new[] { "Mike", "Paul", "Rick" };
            object[] randomArray = { "Paul", 45, 1.234 };

            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());
            Console.WriteLine("Array Size : {0}",
                randomArray.Length);

            // For Loop:
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array {0} : Value : {1}",
                j, randomArray[j]);
            }

            // Multidimensional arrays
            string[,] custNames = new string[2, 2] { { "Bob", "Smith" },
                { "Sally", "Smith" } };

            Console.WriteLine("MD Value : {0}",
                custNames.GetValue(1, 1));

            for (int j = 0; j < custNames.GetLength(0); j++)
            {
                for (int k = 0; k < custNames.GetLength(1); k++)
                {
                    Console.Write("{0} ", custNames[j, k]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };
            PrintArray(randNums, "ForEach");
        }

    }
}



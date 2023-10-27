using System;
using System.Net;

namespace LearningSharper3
{
    public class Program
    {

        // ---FUNCTIONS---

        static double DoDivision(double x, double y)
    {
        if (y == 0)
        {
            // We are throwing an exception because
            // you can't divide by zero
            throw new System.DivideByZeroException();
        }
        return x / y;
    }



        // ---END OF FUNCTIONS---
        static void Main(string[] args)
    {
        // Relational Operators: > < >= <= == !=
        // Logical Operators: && || !

        /*int age = 17;
        if ((age >= 5) && (age <=7))
        {
            Console.WriteLine("Go to elementary school");
        }
        if ((age >= 7) && (age <= 13))
        {
            Console.WriteLine("Go to middle school");
        }
        if ((age >= 13) && (age <= 19))
        {
            Console.WriteLine("Go to high school");
        } 
        else 
        { 
            Console.WriteLine("Go to college"); 
        }
        if ((age < 14) || (age > 67))
        {
            Console.WriteLine("Cannot work");
        }
        Console.WriteLine("! True = " + (!true));

        bool canDrive = age >= 16 ? true : false;

        switch (age)
        {
            case 1:
            case 2:
                Console.WriteLine("Go to Daycare");
                break;
            case 3:
            case 4:
                Console.WriteLine("Go to Preschool");
                break;
            case 5:
                Console.WriteLine("Go to Kindergarten");
                break;
            default:
                Console.WriteLine("Go to another school");
                goto OtherSchool;
        }
    OtherSchool:
        Console.WriteLine("Elemenatry, Middle, High School");

        string name2 = "Derek";
        string name3 = "Derek";
        if (name2.Equals(name3, StringComparison.Ordinal))
            {
            Console.WriteLine("Names are Equal");
            }*/

        // While Loops:
        /*int i = 1;
        while (i <= 10)
        {
            if (i % 2 == 0)
            {
                i++;
                continue;
            }
            if (i == 9) break;
            Console.WriteLine(i);
            i++;
        }*/
        // Do While:
        /*Random rnd = new Random();
        int secretNumber = rnd.Next(1, 11);
        int numberGuessed = 0;
        Console.WriteLine("Random Num : ", secretNumber);

        do
        {
            Console.WriteLine("Enter a Number between 1-10 :");
            numberGuessed = Convert.ToInt32(Console.ReadLine());
        } while (secretNumber != numberGuessed);

        Console.WriteLine("You guessed it was {0}", secretNumber);*/

        // Exception Handling:
        double num1 = 5;
        double num2 = 0;

        try
        {
            Console.WriteLine("5 / 0 = {0}",
                DoDivision(num1, num2));
        }

        // We catch the error and warn the user
        // rather then crash the program
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You can't Divide by Zero");

            // Get additonal info on the exception
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);

        }

        // This is the default catch all for exceptions
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
        }

        // finally always runs and provides for clean up
        finally
        {
            Console.WriteLine("Cleaning Up");
        }

        }
    }   
}

<<<<<<< HEAD
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GPACalculator
{
    class GPACalculator
    {
        static void Main(string[] args)
        {
        //The first step is to declare your variables
        //Use string since your variable will be recorded as a name
        string name, first,second,third,fourth;
        //Use decimal since GPA's can include decimals, i.e. 3.75.
        decimal sum, GPA;
        //Because of the "using static System.Console" we typed farther up, we can simply put Write() instead of Console.WriteLine()
        Write("Hello and welcome to the weighted GPA Calculator program, please enter your name...");
        //The string name is equal to whatever the user types as their name
        name = ReadLine();
        //The {0} in the sentence below means that the first variable given is put in place of {0}, so whatever name the user gave for the name variable is inserted into that spot
        Write("Hello {0}! Enter your first quarter GPA:", name);
        //The decimal first is equal to the GPA given in the line above
        first = ReadLine();
            Write("Thanks {0}! Now please include your second quarter GPA:", name);
          //The decimal second is equal to the GPA given in the line above
          second = ReadLine();
        Write("Thank you {0}! Now please enter your third quarter GPA:", name);
        //The decimal third is equal to the GPA given in the line above
        third = ReadLine();
        Write("And please enter your fourth quarter GPA as well:");
        //The decimal fourth is equal to the GPA given in the line above
        fourth = ReadLine();
            ReadLine();
            //The decimal sum is equal to the addition of the four quarter GPA scores
            decimal first1 = System.Convert.ToDecimal(first);
            decimal second2 = System.Convert.ToDecimal(second);
            decimal third3 = System.Convert.ToDecimal(third);
            decimal fourth4 = System.Convert.ToDecimal(fourth);
        sum = first1 + second2 + third3 + fourth4;
           //The overall GPA for that year is shown as decimal GPA, which is equal to the sum / 4 due to their being 4 numbers being added in total.
        GPA = sum / 4;
        //Finally, the average GPA for the year is given out using the GPA variable in place of {0}
        Write("Your GPA is {0}, thank you for using the GPA Calculator!", GPA);
            ReadLine();
        //continue on this line\\
        }
    }
}
>>>>>>> f23c373773ae66930b55ae781223adf94ab15b67

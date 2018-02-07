using System;
using system.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GPACalculator
{
  class GPACalculator;
    {
        static void main(string[] args)
        {
          string name, predictions;
          int first, second, third, fourth;
          decimal sum, GPA;
          Write("Hello and welcome to the weighted GPA Calculator program, please enter your name...");
          name = ReadLine();
          Write("Hello {0}! Enter your first quarter GPA:", name);
          first = ReadLine();
          Write("Thanks {0}! Now please include your second quarter GPA:",name)
          second = ReadLine();
          Write("Thank you {0}! Now please enter your third quarter GPA:", name);
          third = ReadLine();
          Write("And please enter your fourth quarter GPA as well:");
          fourth = ReadLine();
          sum = first + second + third + fourth;
          GPA = sum / 4;
          Write("Your GPA is {0}, thank you for using the GPA Calculator!", GPA);
          //continue on this line\\
        }
    }
}

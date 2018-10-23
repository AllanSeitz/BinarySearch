using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      //number range
      var min = 1;
      var max = 1000;
      var guess = "";
      var pick = (max + min) / 2;

      Console.WriteLine($"Choose a number beetween {min} and {max} remember your number");

      while (guess != "y")
      {
        //let user select a number
        Console.WriteLine($"Is your number higher or lower than or equal to {pick}? choose h/l/y");

        guess = Console.ReadLine();
        if (guess == "h")
        {
          pick = ((pick + max) / 2) + 1;
        }
        else if (guess == "l")
        {
          pick = ((pick + min) / 2) - 1;
        }
        else if (guess == "y")
        {
          Console.WriteLine($"Your number is {pick}");
        }
        Console.WriteLine($"Is your number higher or lower than or equal to {pick}? choose h/l/y");
      };
    }
  }
}

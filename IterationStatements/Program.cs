using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO - Read each comment and complete its instruction
            // like the example below

            //Create a List called "numbers" - DONE!
            var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            int num = 0;


            // Create a do-while loop and use the template below:
            do
            {
                // Increment num by 1
                num++;
                // Then add num to the collection - numbers
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

            } while (num < 100);



            // Create a while loop
            while (num < 200)// <--- While num is less than 200
            {
                num++;
                numbers.Add(num);
                // Then add num to the collection numbers
                //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            } 


            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (var i = 200; i >= 1; i--)
            {
                Console.WriteLine(numbers[i]);
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}

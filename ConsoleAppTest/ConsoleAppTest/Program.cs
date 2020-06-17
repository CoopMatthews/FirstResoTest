using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars Here
            string name;
            int age;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("You must be over 18 years old to enter!\n How old are you? ");
            age = int.Parse(Console.ReadLine());

            // If statements
            if (age >= 18 && age < 70)
            {
                Console.WriteLine("Nice, Welcome to the Club!");
            }
            else if (age < 18 || age >= 70)
            {
                Console.WriteLine("No access");
            }


            Console.ReadKey();
        }
    }
}

// CheatSheet
// SYMBOLS:
//Greater than:      >
//Less than:         <
//Or:                ||
//And:               &&
//Equals:            == (check if something is the same as)
//Set Equals         =  (Assign a new value)
// Incriment of 1    ++ (Will add + 1) -- (Will subtract =1)


//COMMON FUNCTIONS / METHODS

// Writes to the Display then moves to next line
//Console.WriteLine();

// Writes to the Display then waits on the same line
//Console.Write();

// Reads what the user has inputed (Writes a line of w/e and press enter)
//Console.ReadLine();

// Console waits for the user to press a key before contiuing
//Console.ReadKey();

    //   if (Condition (True / False) or example == example1)
    //{
    //       Do something here
    //}
    //   else if (Condition (True / False) or example == example1)
    //{
    //       Do something else here
    //}

   // for Loop

   // for (int i = 0; i<length; i++)
			//{
   //             // Do something here
			//}
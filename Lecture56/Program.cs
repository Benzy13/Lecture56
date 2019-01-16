using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture56
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1
            //This program continuously asks the user to enter different names, until the user presses Enter.
            //A message is displayed depending on the number of names provided.

            var myList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or press enter");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                    myList.Add(input);

                else
                    break;
            }

            if (myList.Count == 1)
                Console.WriteLine("{0} like your post", myList[0]);
            
            else if (myList.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", myList[0], myList[1]); 

            else
                Console.WriteLine("{0}, {1} and {2} others like your post.", myList[0], myList[1], (myList.Count - 2));


            //Question 2
            //Write a program and ask the user to enter their name.
            //Use an array to reverse the name and then store the result in a new string.
            //Display the reversed name on the console.

            Console.WriteLine("Enter your name:");
            string myName = Console.ReadLine();
            char[] nameArray = myName.ToCharArray();
            Array.Reverse(nameArray);
            string nameReversed = new string(nameArray);
            Console.WriteLine(nameReversed);
            Console.WriteLine(myName);

            //Question 3
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            int[] numbers = new int[5];

            Console.WriteLine("Enter {0} numbers, press enter after each number, the numbers you enter must be unique.", numbers.Length);

            int i = 0;
            while (i < numbers.Length)
            {
                Console.WriteLine("{0}) Enter Unique Number:", i+1);
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input); 

                foreach (int item in numbers)
                {
                    if (item == number)
                    {
                        Console.WriteLine("You have already entered this number. Try again.");
                        break;
                    }

                    else if (Array.IndexOf(numbers, item) == i)
                    {
                        numbers[i] = number;
                        i++;
                        break;
                    }
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("Sorting...");
            foreach (var item in numbers)
                Console.WriteLine(item);

            //Question 4
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates.
            //Display the unique numbers that the user has entered.

            //Question 5
            //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.
        }
    }
}

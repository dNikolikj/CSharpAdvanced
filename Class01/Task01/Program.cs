using System;
using System.Collections.Generic;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            //## 1. Create a console application that detect count of provided names in a provided text 🔹
            //*The application should ask for names to be entered until the user enteres x
            //* After that the application should ask for a text (sentence)
            //*When that is done the application should show how many times that name was included in the text ignoring upper / lower case -->

            List<string> names = new List<string>(5);

            while (true)
            {
                Console.WriteLine("Please enter names or press x when you are done entering names:");
                string name = Console.ReadLine();
                if (name.ToLower() == "X".ToLower() || String.IsNullOrEmpty(name))
                {
                    break;
                }
                else
                {
                    names.Add(name);

                }
            }

            Console.WriteLine("The names that the user has entered are:");
            foreach (string input in names)
            {
                Console.WriteLine(input);
            }

            Console.WriteLine("Please enter a sentence:");


            string sentence = Console.ReadLine();
            string[] input1 = sentence.Split(" ");


            foreach (var item in names)
            {
                int counter = 0;
                // counter
                foreach (var item1 in input1)
                {
                    if (item == item1)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"The {item} has been entered {counter} times.");
                counter = 0;

            }





        }
    }
}

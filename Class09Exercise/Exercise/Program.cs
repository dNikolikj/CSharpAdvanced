using System;
using System.IO;
namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();

            string absolutePath = currentDirectory;

            var exerciseFolder = absolutePath + @"\Exercise\";

            if (!Directory.Exists(exerciseFolder))
            {
                Console.WriteLine($"Folder {exerciseFolder} does not exist. Creating folder...");

                Directory.CreateDirectory(exerciseFolder);

                Console.WriteLine($"Folder {exerciseFolder} was created");
            }

            string textFile = exerciseFolder + "calculations.txt";

            if (!File.Exists(textFile))
            {
                Console.WriteLine($"File {textFile} does not exist. Creating file...");

                File.Create(textFile).Close();

                Console.WriteLine($"File {textFile} was created");
            }

            string result;
            for (int i = 0; i < 3; i++) { 
                Console.WriteLine("Please enter your first number:");
            bool firstParsingResult = double.TryParse(Console.ReadLine(), out double num1);
            Console.WriteLine("Please enter your second number:");
            bool secondParsingResult = double.TryParse(Console.ReadLine(), out double num2);
            if (!firstParsingResult || !secondParsingResult)
            {
                Console.WriteLine("Invalid inputs for numbers");
                return;
            } else
            {
                 result = Calculator.SimpleCalculator(num1, num2);
            }

            

                DateTime localDate = DateTime.Now;

                string dateToString = localDate.ToString();

                Helper.AppendTextInFile(textFile, result, dateToString);

            }
            Console.WriteLine("TextFile content: ");

            using (StreamReader sr = new StreamReader(textFile))
            {
                string currentContent = sr.ReadToEnd();
                Console.WriteLine(currentContent);
            }
        }
    }
}

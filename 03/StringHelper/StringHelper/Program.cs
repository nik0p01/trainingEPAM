using System;
using System.IO;

namespace StringHelper
{
    class Program
    {
        private static readonly string defaultName = "text.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Please input name file with telephone numbers (default text.txt)");
            var nameFile = Console.ReadLine();
            if (nameFile.Length == 0)
            {
                nameFile = defaultName;
            }
            string textIn = null;
            try
            {
                textIn = File.ReadAllText(nameFile);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading file {nameFile}. Error message: {e.Message}");
                return;
            }

            var phones = TakePhones.TakePhonesFromString(textIn);
            var phonesString = String.Empty;
            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
                phonesString += $"{phone}{Environment.NewLine}";
            }
            try
            {
                File.WriteAllText("Numbers.txt", phonesString);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error writing file Numbers.txt. Error message: {e.Message}");
                return;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Error access file Numbers.txt. Error message: {e.Message}");
                return;
            }
        }
    }
}

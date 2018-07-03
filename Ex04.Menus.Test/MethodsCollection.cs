using System;

namespace Ex04.Menus.Test
{
    public class MethodsCollection
    {
        private const int k_Add = 1;
        private const int k_StaySame = 0;

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now.Date.ToString("dd/MM/yyyy"));
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        public void CountCapital()
        {
            string input;
            int    numberOfCapitalLetters;

            printOpeningMessage();
            input = getStringFromUser();
            numberOfCapitalLetters = getNumberOfCapitalLettersInString(input);
            printFinalMessage(input, numberOfCapitalLetters);
        }

        private string getStringFromUser()
        {
            string input;

            input = Console.ReadLine();
            while (input == string.Empty) 
            {
                Console.WriteLine("Invalid. Please enter sentence:");
                input = Console.ReadLine();
            }
            
            return input;
        }

        private void printOpeningMessage()
        {
            Console.WriteLine("Please enter sentence:");
        }

        private int getNumberOfCapitalLettersInString(string input)
        {
            int numberOfCapitalLetters = 0;

            foreach (char letter in input)
            {
                numberOfCapitalLetters += char.IsUpper(letter) ? k_Add : k_StaySame;
            }

            return numberOfCapitalLetters;
        }

        private void printFinalMessage(string i_Input, int i_NumberOfCapitalLetters)
        {
            string messasge = string.Format(
                @"There is {0} Capital Letters in the sentence: 
{1}",
                i_NumberOfCapitalLetters.ToString(),
                i_Input);

            Console.WriteLine(messasge);
        }

        public void ShowVerison()
        {
            Console.WriteLine("Version: 18.2.4.0");
        }
    }
}
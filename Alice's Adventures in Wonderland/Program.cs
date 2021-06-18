using System;

namespace Alice_s_Adventures_in_Wonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you read Alice's Adventure in Wonderland? \n");
            Console.WriteLine("Here is a short piece \n");
            string quote = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice \n she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it," +
                " 'and what is the \n use of a book," +
                "' thought Alice 'without pictures or conversation?'";
            Console.WriteLine($"\"{quote}\"");
            Console.WriteLine("============================================== \n");
            Console.WriteLine("Enter a word to check if it exist in the secentes: ");
            string userInput = Console.ReadLine();
            string word = userInput;
            quote.ToLower();
            bool containsSearchResult = quote.ToLower().Contains(word);

            if(containsSearchResult == true)
            {
                Console.WriteLine(" (Yes) Word was found in this passage");
            }
            else
            {
                Console.WriteLine(" (No) Word was not found in this passage");
            }

        }
    }
}

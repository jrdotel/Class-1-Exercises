using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lowerCaseQuote = quote.ToLower();
            string input;

            //! User query
            Console.WriteLine("Enter a term to search within this string: ");
            input = Console.ReadLine();
            string lowerCaseInput = input.ToLower();


            if (lowerCaseQuote.IndexOf(lowerCaseInput) != -1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

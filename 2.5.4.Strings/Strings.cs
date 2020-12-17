using System;

namespace _2._5._4.Strings
{
    class Strings
    {
        static void Main(string[] args)
        {
            /* ATTEMPT 1:
             * 
             * Console.WriteLine("Please enter a term to search for in this excerpt: ");

            string excerpt = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string toFind = string.Parse(Console.ReadLine());
            string search = aliceInWonderland.Contains(toFind);
            bool a = toFind.Contains(search);
            Console.WriteLine("'{0}' was found in '{1}': {2}", toFind, excerpt, search, a);
                if (a)
            {
                //int index = search.IndexOf(toFind);
                //if (index >= 0)
                  //  Console.WriteLine("'{0} begins at character position {1}", ) */

            //WALKTHROUGH WITH BEN:

            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.WriteLine(sentence);
            Console.WriteLine("Search within this sentece: ");

            string searchTerm = Console.ReadLine();

            bool found = sentence.ToLower().Contains(searchTerm);
            Console.WriteLine(found);

            int foundIndex = sentence.ToLower().IndexOf(searchTerm.ToLower());
            Console.WriteLine(foundIndex);
            Console.WriteLine(searchTerm.Length);

            }
        }
    }

//how would I handle this by adding other conditionals to the search? such as returning all instances of the word, or finding a portion of the text through keywords even if the search does not contain all the words within the string in the same order?
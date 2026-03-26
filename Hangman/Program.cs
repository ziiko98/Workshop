using System;

namespace Hangman
{
    class Program
    {
        static void Main()
        {

            // Hangman is a game where the player guesses letters in a hidden word.
            // The player will have 10 tries to guess the mysterious word. 
            // Correct guesses show letters, wrong guesses loses tries.

            Console.WriteLine("Welcome to the Hangman game!");
            string[] words = { "fruit", "cat", "pear", "dog", "bag" };
            // Picks a random word from the list for the player to guess.
            Random random = new Random();
            string word = words[random.Next(words.Length)];
            
            // Created a char array to show the word as underscores.
            char[] shownWord = new char[word.Length];
            for (int i = 0; i < shownWord.Length; i++)
            {
                shownWord[i] = '_';
            }
            int tries = 10;
            string guessedLetters = "";
            // The loop is made to continue even if the player guessed wrong, only ends when you lose all tries or guess right.
            while (tries > 0)
            {
                 // Formats the char array into a string separated by spaces.
                Console.WriteLine(string.Join(" ", shownWord));
                Console.WriteLine("Guessed letters: " + guessedLetters);
                Console.WriteLine("Enter a letter: ");
                string guess = Console.ReadLine();
                guessedLetters += guess + " ";

                // Boolean to check if the guess is correct.
                bool correct = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess[0])     
                    {
                        shownWord[i] = guess[0];
                        correct = true;
                    }
                }
                // New string coverts the char string to a string to check if the word is guessed.
                if (new string(shownWord) == word)
                {
                    Console.WriteLine("Congratulations! You won :)");
                    return;
                }

                if (!correct)
                {
                    tries--;
                    Console.WriteLine("Wrong Guessed!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }

                Console.WriteLine("Tries left: " + tries);
                Console.WriteLine();
            }

            Console.WriteLine("Game Over! The word was: " + word);
            {
            }
        }
    }
}
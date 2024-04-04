namespace HangMan
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int entry, letters, guesses = 7;
            bool   playing = true, eFalse = false;
            string word = "", guess = "";

            Random generator = new Random();
            List <string> words = new List<string>();

            words.Add("Star");
            words.Add("Moon");
            words.Add("Gamma");
            words.Add("Nebula");
            words.Add("Planet");
            words.Add("Galaxy");
            words.Add("Quasar");
            words.Add("Supernova");
            words.Add("Interstellar");
            words.Add("Nucleosynthesis");

            List <string> L = new List<string>();

            L.Add("____\r\n|/   |\r\n|   \r\n|    \r\n|    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|    \r\n|    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|    |\r\n|    |    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|   \\|\r\n|    |\r\n|    \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|    \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|   / \r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|   / \\\r\n|\r\n|_____\r\n\"\"\";");
            L.Add(" ____\r\n|/   |\r\n|   (_)\r\n|   /|\\\r\n|    |\r\n|   | |\r\n|\r\n|_____\r\n\"\"\"]");


            Console.WriteLine("Welcome to the hangman game. You will have a total of seven guesses for each word. \n\rFor default words enter 1. For custom words enter 2.");
            entry = Convert.ToInt32(Console.ReadLine());

            if (entry == 1)
            {
            }
            else if (entry == 2)
            {
            }
            else
            {
                while (!eFalse)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry, please try again:");
                    entry = Convert.ToInt32(Console.ReadLine());
                    if (entry == 1)
                    {
                        break;
                    }
                    else if (entry == 2)
                    {
                        break;
                    }
                    else
                    {

                    }
                    
                }
            }

            if (entry == 1)
            {
                Console.Clear() ;
                Console.WriteLine("All default words are astronomy themed. Enter 1 for easy mode, 2 for medium mode, or 3 for hard mode:");
                entry = Convert.ToInt32(Console.ReadLine());

                if (entry == 1)
                {
                    word = words[generator.Next(1, 4)];
                }
                else if (entry == 2)
                {
                    word = words[generator.Next(4, 7)];
                }
                else if (entry == 3)
                {
                    word = words[generator.Next(7, 10)];
                }
                else
                {
                    while (!eFalse)
                    {
                        Console.Clear ();
                        Console.WriteLine("Invalid entry, please try again:");
                        Console.WriteLine();
                        entry = Convert.ToInt32(Console.ReadLine());
                        if (entry == 1)
                        {
                            word = words[generator.Next(1, 4)];
                            break;
                        }
                        else if (entry == 2)
                        {
                            word = words[generator.Next(4, 7)];
                            break;
                        }
                        else if (entry == 3)
                        {
                            word = words[generator.Next(7, 10)];
                            break;
                        }
                       
                    }

                }
                char[] guessed = new char[word.Length];

                while (playing)
                {


                    Console.Clear();
                    if (guesses == 7)
                    {
                        Console.WriteLine(L[1]);
                    }
                    else if (guesses == 6)
                    {
                        Console.WriteLine(L[2]);
                    }
                    else if (guesses == 5)
                    {
                        Console.WriteLine(L[3]);
                    }
                    else if (guesses == 4)
                    {
                        Console.WriteLine(L[4]);
                    }
                    else if (guesses == 3)
                    {
                        Console.WriteLine(L[5]);
                    }
                    else if (guesses == 2)
                    {
                        Console.WriteLine(L[6]);
                    }
                    else if (guesses == 1)
                    {
                        Console.WriteLine(L[7]);
                    }
                    else if (guesses == 0)
                    {
                        Console.WriteLine(L[8]);
                        break;
                    }

                    letters = word.Length;
                    for (int i = 0; i < letters; i++)
                    {
                        guessed[i] = '_';
                    }

                    Console.WriteLine();
                    Console.WriteLine("Guessed letters: " + string.Join(" ", guessed));
                    Console.WriteLine("Enter your guess below. You have " + guesses + " left.");
                    Console.WriteLine();

                    guess = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < letters; i++)
                    {
                        if (char.ToLower(word[i]) == char.ToLower(char.Parse(guess)))
                        {
                            found = true;
                            guessed[i] = word[i]; 
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("");

                    if (found)
                    {
                        Console.WriteLine("Correct guess!");

                        
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (char.ToLower(word[i]) == char.ToLower(char.Parse(guess)))
                            {
                                guessed[i] = word[i];
                            }
                        }


                        
                        if (string.Join("", guessed) == word)
                        {
                            Console.WriteLine("Congratulations! You've guessed the word: " + word);
                            break; 
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("You Lost!");
            }
            else if (entry == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter your custom word:");
                word = Console.ReadLine();
            }






        }
    }
}
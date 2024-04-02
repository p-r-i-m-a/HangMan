namespace HangMan
{
    internal class Program
    {

        public static void l1() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   \r\n|    \r\n|    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l2() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|    \r\n|    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l3() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|    |\r\n|    |    \r\n|    \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l4() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|   \\|\r\n|    |\r\n|    \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l5() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|    \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l6() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|   / \r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l7() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|   \\|/\r\n|    |\r\n|   / \\\r\n|\r\n|_____\r\n\"\"\";");
        }
        public static void l8() 
        {
            Console.Clear();
            Console.WriteLine("____\r\n|/   |\r\n|   (_)\r\n|   /|\\\r\n|    |\r\n|   | |\r\n|\r\n|_____\r\n\"\"\"]");
        }


        static void Main(string[] args)
        {
            int entry;
            bool eFalse = false;
            string word;

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
                    eFalse = false;
                    while (!eFalse)
                    {
                        Console.Clear ();
                        Console.WriteLine("Invalid entry, please try again:");
                        Console.WriteLine();
                        entry =
                    }

                }
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
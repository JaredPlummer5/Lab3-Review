using System;
using System.Text;
using System.IO;

namespace Lab3;

public static class Program
{
    static void Main(string[] args)
    {
        int play = 0;
        Animatation();
        //Console.WriteLine("Hello, World!");
        do
        {


            
            Console.WriteLine("Enter 1 to run Challenge 1");
            Console.WriteLine("Enter 2 to run Challenge 2");
            Console.WriteLine("Enter 3 to run Challenge 3");
            Console.WriteLine("Enter 4 to run Challenge 4");
            Console.WriteLine("Enter 5 to run Challenge 5");
            Console.WriteLine("Enter 6 to run Challenge 6");
            Console.WriteLine("Enter 7 to run Challenge 7");
            Console.WriteLine("Enter 8 to run Challenge 8");
            Console.WriteLine("Enter 9 to run Challenge 9");
            Console.WriteLine("Enter 10 to exit");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                Challenge_1();
                Console.ReadLine();
            }
            else if (action == 2)
            {
                Challenge_2();

                Console.ReadLine();

            }
            else if (action == 3)
            {
                Challenge_3();
                Console.ReadLine();
            }
            else if (action == 4)
            {
                Challenge_4();
                Console.ReadLine();

            }
            else if (action == 5)
            {
                Challenge5();
                Console.ReadLine();
            }
            else if (action == 6)
            {
                Challenge_6();
                Console.ReadLine();
            }
            else if (action == 7)
            {
                Challenge_7();
                Console.ReadLine();
            }
            else if (action == 8)
            {
                Challenge_8();
                Console.ReadLine();
            }
            else if (action == 9)
            {
                string[][] result = Challenge_9();

                foreach (string[] wordWithCount in result)
                {
                    string word = wordWithCount[0];
                    string characterCount = wordWithCount[1];

                    Console.WriteLine($"Word: {word}, Character Count: {characterCount}");
                }
                Console.WriteLine(" ");
            }
            else if(action == 10)
            {
                play = 1;
            }

        } while (play == 0);


    }

    static void Animatation()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to the Awesome Game!");
        Thread.Sleep(1500);
        Console.Clear();

        string[] frames = new string[]
        {
            @"   _____ _                            _____ _             _",
            @"  / ____| |                          / ____| |           | |",
            @" | |    | |__   ___   ___  ___  ___ | |    | | __ _ _ __ | |_",
            @" | |    | '_ \ / _ \ / _ \/ _ \/ __|| |    | |/ _` | '_ \| __|",
            @" | |____| | | | (_) |  __/  __/\__ \| |____| | (_| | | | | |_",
            @"  \_____|_| |_|\___/ \___|\___||___/\_____|_|\__,_|_| |_|\__|",
            @"",
            @"",
            @"                 Press any key to start the game!"
        };

        Console.CursorVisible = false;

        for (int i = 0; i < frames.Length; i++)
        {
            Console.SetCursorPosition(0, i+2);

            for (int j = 0; j < frames[i].Length; j++)
            {
                Console.Write(frames[i][j]);
                Thread.Sleep(5);
            }

            Thread.Sleep(150);
        }

        Console.CursorVisible = true;
        Console.ReadKey(true);
        Console.Clear();
    
}
    public static int Challenge_1()
    {
        Console.Write("Please enter 3 numbers: ");
        string? numbers = Console.ReadLine();

        if (string.IsNullOrEmpty(numbers))
        {
            Console.WriteLine("Input is empty or null.");
            return 0;
        }

        string[] stringOfNumbersArray = numbers.Split(" ");


        int[] actualNumbersArray = new int[3];
        int product = 1;


        for (int i = 0; i < actualNumbersArray.Length; i++)
        {

            if (string.IsNullOrEmpty(numbers))
            {
                Console.WriteLine("Input is empty or null.");
            }


            if (int.TryParse(stringOfNumbersArray[i], out int num))
            {

                Console.WriteLine("Input is a valid number: " + num);
                actualNumbersArray[i] = Convert.ToInt32(stringOfNumbersArray[i]);
            }
            else
            {
                // Input is not a number, assign default value of 1
                num = 1;

                Console.WriteLine("Input is not a number. Assigned default value: " + num);
                actualNumbersArray[i] = num;
            }


            product *= actualNumbersArray[i];

        }
        Console.WriteLine($"The product of these 3 numbers is: {product}");

        return product;
    }



    public static int Challenge_1_Test(string numbers)
    {
        string[] stringOfNumbersArray = numbers.Split(" ");
        if (stringOfNumbersArray.Length < 3)
        {
            return 0;

        }
        int[] actualNumbersArray = new int[3];
        int product = 1;
        for (int i = 0; i < actualNumbersArray.Length; i++)
        {


            if (string.IsNullOrEmpty(numbers))
            {
                Console.WriteLine("Input is empty or null.");
            }


            if (int.TryParse(stringOfNumbersArray[i], out int num))
            {

                Console.WriteLine("Input is a valid number: " + num);
                actualNumbersArray[i] = Convert.ToInt32(stringOfNumbersArray[i]);

            }
            else
            {
                // Input is not a number, assign default value of 1
                num = 1;
                Console.WriteLine("Input is not a number. Assigned default value: " + num);
                actualNumbersArray[i] = num;
            }


            product *= actualNumbersArray[i];


        }

        return product;

    }




    public static decimal Challenge_2()
    {

        Console.Write("Please enter a number between 2-10:");

        int length = Convert.ToInt32(Console.ReadLine());
        while (length < 2 || length > 10)
        {
            Console.Write("Please enter a number between 2-10:");
            length = Convert.ToInt32(Console.ReadLine());
        }
        decimal[] range = new decimal[length];
        decimal sum = 0;
        for (int i = 0; i < range.Length; i++)
        {
            Console.Write($"{i + 1} of {range.Length} - Enter a number: ");
            decimal userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput >= 0)
            {
                sum += userInput;
            }
            else
            {
                sum += 0;
                Console.WriteLine("Input is not a number. Assigned default value: 0");
            }
        }
        decimal average = sum / Convert.ToDecimal(range.Length);
        Console.WriteLine($"The average of these {range.Length} numbers is: {average}");
        return average;



    }



    public static decimal Challenge_2_Test(int lengthInput, decimal[] range)
    {
        decimal sum = 0;
        for (int i = 0; i < range.Length; i++)
        {
            if (range[i] >= 0)
            {
                sum += range[i];
            }
            else
            {
                return 0;
            }
        }
        decimal average = sum / range.Length;
        return average;
    }


    public static void Challenge_3()
    {
        Console.WriteLine("      *");
        Console.WriteLine("     ***");
        Console.WriteLine("    *****");
        Console.WriteLine("   *******");
        Console.WriteLine("  *********");
        Console.WriteLine("   *******");
        Console.WriteLine("    *****");
        Console.WriteLine("     ***");
        Console.WriteLine("      *");


    }




    public static int Challenge_4()
    {

        Console.Write("Please enter a number between 1 and 10: ");

        int length = Convert.ToInt32(Console.ReadLine());

        while (length < 1 || length > 10)
        {
            Console.Write("Please enter a number between 1 and 10:");
            length = Convert.ToInt32(Console.ReadLine());
        }

        int[] numbers = new int[length];
        int userInput;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1} of {numbers.Length} - Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            numbers[i] = userInput;
        }

        int mostFrequentNum = numbers[0];
        int mostFrequentCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    count++;
                }
            }

            if (count > mostFrequentCount)
            {
                mostFrequentCount = count;
                mostFrequentNum = numbers[i];
            }
        }

        Console.WriteLine($"Output: {mostFrequentNum}");
        return mostFrequentNum;
    }



    public static int Challenge_4_Test(int[] numbers)
    {


        int mostFrequentNum = numbers[0];
        int mostFrequentCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    count++;
                }
            }

            if (count > mostFrequentCount)
            {
                mostFrequentCount = count;
                mostFrequentNum = numbers[i];
            }
        }

        return mostFrequentNum;
    }


    public static int Challenge5()
    {
        Console.Write("Please enter a number between 1 and 10: ");

        int length = Convert.ToInt32(Console.ReadLine());

        while (length < 1 || length > 10)
        {
            Console.Write("Please enter a number between 1 and 10:");
            length = Convert.ToInt32(Console.ReadLine());
        }

        int[] numbers = new int[length];
        int userInput;
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1} of {numbers.Length} - Enter a number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            numbers[i] = userInput;
        }


        int highestNum = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (highestNum < numbers[i])
            {

                highestNum = numbers[i];
            }
        }

        Console.WriteLine($"The highest number was {highestNum}");
        return highestNum;

    }



    public static int Challenge_5_Test(int[] numbers)
    {
        int highestNum = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (highestNum < numbers[i])
            {

                highestNum = numbers[i];
            }
        }
        return highestNum;
    }

    public static void Challenge_6()
    {
        Console.Write("Please enter a word: ");
        string? word = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter("/Users/jaredplummer/projects/Lab3/Lab3/words.txt", true))
            {
                writer.WriteLine(word);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while writing to the file: " + e.Message);
        }
       
    }

    public static void Challenge_7()
    {

        if(File.Exists("/Users/jaredplummer/projects/Lab3/Lab3/words.txt"))
        {
            string fileContent = File.ReadAllText("/Users/jaredplummer/projects/Lab3/Lab3/words.txt");
            Console.WriteLine(fileContent);
        }
    }

    public static void Challenge_8()
    {
        Console.Write("Enter the word to remove: ");
        string? wordToRemove = Console.ReadLine();

        string filePath = "/Users/jaredplummer/projects/Lab3/Lab3/words.txt";

        // Read all lines from the file
        string[] lines = File.ReadAllLines(filePath);

        bool wordFound = false;

        // Iterate over each line and remove the word if found
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Equals(wordToRemove, StringComparison.OrdinalIgnoreCase))
            {
                lines[i] = string.Empty;  // Remove the word by setting the line to an empty string
                wordFound = true;
                break;
            }
        }

        if (wordFound)
        {
            // Write the updated lines back to the file
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Word removed and file updated successfully.");
        }
        else
        {
            Console.WriteLine("Word not found in the file.");
        }


    }

    public static string[][] Challenge_9()
    {
        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');

        string[][] wordsWithCount = new string[words.Length][];
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            int characterCount = word.Length;

            wordsWithCount[i] = new string[] { word, characterCount.ToString() };
        }

        return wordsWithCount;
    }



}


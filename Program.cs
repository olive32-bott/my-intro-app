// See https://aka.ms/new-console-template for more information
using System;

class AboutOliviaApp
{
    static void Main()
    {
        string GetRequiredInput(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine() ?? "0";
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        int GetValidAge(string prompt)
        {
            int age;
            while (true)
            {
                string input = GetRequiredInput(prompt);

                if (int.TryParse(input, out age) && age >= 1 && age <= 120)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Please enter a valid age between 1 and 120.");
                }
            }
        }

        string name = GetRequiredInput("What is your name? ");
        int age = GetValidAge("How old are you? ");
        string homeTown = GetRequiredInput("Where do you come from? ");
        string birthPlace = GetRequiredInput("Where were you born? ");
        string complexion = GetRequiredInput("What is your complexion? ");
        string hobby = GetRequiredInput("What is your favorite hobby? ");
        string favoriteFood = GetRequiredInput("What is your favorite food? ");
        string familySize = GetRequiredInput("How many people are in your family? ");

        // output
        Console.WriteLine("\n--- MYSELF ---\n");
        Console.WriteLine($"My name is {name}.\n");
        Console.WriteLine ($"I am {age} years old.\n"); 
        Console.WriteLine($"I come from {homeTown} in the Eastern region of Ghana.\n");
        Console.WriteLine($"However, I was born in {birthPlace}.\n");
        Console.WriteLine($"I am {complexion} in complexion and enjoy {hobby} during my free times.\n");
        Console.WriteLine($"My favorite food is {favoriteFood}.\n");
        Console.WriteLine($"I come from a family of {familySize} people, and I am the second-born of my parents.\n");
        Console.WriteLine($"I am currently doing an internship because I want to write code well and understand it properly.\n");
        Console.WriteLine("That's a little about myself that I would like to share today thanks.\n");
    }
}

using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Try to guess my favorite number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

                Console.WriteLine("Input your guess:");

                var guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Your guess is too high! Sorry");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low! Sorry");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }

            Console.WriteLine("________________________________________________________");
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is difficult!");
                    break;
                case "english":
                    Console.WriteLine("English is my favorite!");
                    break;
                case "science":
                    Console.WriteLine("Science is the best!");
                    break;
                case "social studies":
                    Console.WriteLine("Social Studies is interesting!");
                    break;
                case "geography":
                    Console.WriteLine("Geography is super helpful!");
                    break;
                default:
                    Console.WriteLine($"I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}

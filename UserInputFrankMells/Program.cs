using System;

namespace UserInputFrankMells
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! This is Frank the French Fry! What's your favorite food?");
            Console.WriteLine("Type in the answer and press the ENTER button!");
            string favoriteFood;
            favoriteFood = Console.ReadLine();
            Console.WriteLine("Your favorite food is " + favoriteFood +"? Delicious!");
        }
    }
}

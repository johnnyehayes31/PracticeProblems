using System;
namespace CourseBook
{
 class Program
    {
        public static void Main(String[] args)
        {
        //    int x = 5;
        //    int y = 3;
        //    int z = 4;
        //    int num= x + y + z;
        //    Console.WriteLine(num);
            
           Console.WriteLine("Hello, what is your name?");
           string userInput = Console.ReadLine();
           Console.WriteLine($"Thank you," + " " + (userInput));
           Console.WriteLine(Thread.CurrentThread.Name);

            Console.WriteLine("What kind mood are you in?" + "Good, Ok or Bad?");
            string response;
            response= Console.ReadLine();
            if (response == "Good")
            {
                Console.WriteLine("I am glad your are in such a good mood today?");
            }
            else if (response == "Ok")
            {
                Console.WriteLine ("How can I make it better?");
            }
            else if (response == "Bad")
            {
                Console.WriteLine ("Lets for talk about your day?");
            }
            else
            {
                Console.WriteLine(" I couldn't  figure out mood your are in!");
            }
          


        }
    }
}

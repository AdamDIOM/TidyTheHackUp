using System;

namespace TidyTheHackUp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("It's time to get tidy!");

            Console.WriteLine("The real question is, have you given yourself time to write this hackathon project?");

            string response = Console.ReadLine();

            if(response.ToUpper() == "YES")
            {
                Console.WriteLine("Congratulations! Let's try to make a tidy project");

                Console.WriteLine("Here are some tips for tidy programming:");
                Console.WriteLine("1: Make sure to keep your indents consistent");
                Console.WriteLine("2: Use the same speech marks everywhere (unless your language requires certain ones for certain types");
                Console.WriteLine("3: Keep a good naming convention - always use camel case or always use underscores. Don't mix and match!");
                Console.WriteLine("4: Either separate every line or every block of code with extra lines. Don't have random line breaks");
                Console.WriteLine("5: ALWAYS use comments to tell future-you what's going on here!");

            }
            else
            {
                Console.WriteLine("Oh no! Maybe don't focus on keeping your project tidy but instead just make a project that works!");
            }

        }
    }
}

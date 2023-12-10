using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyConsoleApp{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("========     Hello World     ========");        
            // Console.WriteLine("Hello World");

            Console.WriteLine("========     Variables       ========");
            // int x = 7;
            // int y = x + 3;
            // Console.WriteLine(y);

            // Console.WriteLine("What is your name?");
            // Console.Write("Type your first name: ");
            // // string firstName = Console.ReadLine();
            // Console.Write("Type your last name: ");
            // // string lastName = Console.ReadLine();
            // Console.WriteLine("Hello, " + firstName + " " + lastName);

            Console.WriteLine("========     Decisions       ========");
            // Console.Write("Choose a door: 1, 2 or 3: ");
            // string userInput = Console.ReadLine();
            // string message = "";
            // if(userInput == "1") message = "You won a new car!";
            // else if(userInput == "2") message = "You won a new boat!";
            // else if(userInput == "3") message = "You won a new cat";
            // else message = "Wrong input";
            // Console.WriteLine(message);
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userInput = Console.ReadLine();
            string message = (userInput == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}.", message);
        }
    }
}   
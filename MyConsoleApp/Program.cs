using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyConsoleApp{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("========     HelloWorld      ========");        
            // Console.WriteLine("Hello World");

            Console.WriteLine("========     Variables       ========");
            // int x = 7;
            // int y = x + 3;
            // Console.WriteLine(y);
            // variable declaration
            // int x, y, a, b;
            // int c = 1, d = 6, e = 50;
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
            // Console.Write("Choose a door: 1, 2 or 3: ");
            // string userInput = Console.ReadLine();
            // string message = (userInput == "1") ? "boat" : "strand of lint";
            // Console.WriteLine("You entered: {0}, therefore you won a {1}.", userInput, message);

            Console.WriteLine("========     DataTypes       ========");
            // int myInt = 9;
            // double myDouble = 8.99;
            // ulong myUlong = 18446744073709551615;
            // long myLong = -1844674407370955161;
            // char myChar = 'A';
            // bool myBoolean = false;
            // string myString = "Hello World";

            Console.WriteLine("========     TypeCasting     ========");
            /* implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double */
            // int myInt = 9;
            // double myDouble = myInt;    // automatic casting: int to double
            /* explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char  */                        
            // double myDouble = 9.78;
            // int myInt = (int) myDouble;    // manual casting: double to int
            /* type conversion methods */
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Convert.ToString(myInt);          // convert int to string
            Convert.ToDouble(myInt);          // convert int to double
            Convert.ToInt32(myDouble);        // convert double to int
            Convert.ToString(myBool);         // convert bool to string
            Console.WriteLine("========     Operators       ========");
            int c = 1;
            // in-line conditional operator
            string message = (c == 1) ? "Car" : "Boat";
        }
    }
}   
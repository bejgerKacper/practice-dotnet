using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.XPath;

namespace MyConsoleApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("===== HelloWorld  =====");        
            // Console.WriteLine("Hello World");

            Console.WriteLine("===== Variables   =====");
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

            Console.WriteLine("===== Decisions   =====");
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

            Console.WriteLine("===== DataTypes   =====");
            // int myInt = 9;
            // double myDouble = 8.99;
            // ulong myUlong = 18446744073709551615;
            // long myLong = -1844674407370955161;
            // char myChar = 'A';
            // bool myBoolean = false;
            // string myString = "Hello World";

            Console.WriteLine("===== TypeCasting =====");
            /* implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double */
            // int myInt = 9;
            // double myDouble = myInt;    // automatic casting: int to double
            /* explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char  */                        
            // double myDouble = 9.78;
            // int myInt = (int) myDouble;    // manual casting: double to int
            /* type conversion methods */
            // int myInt = 10;
            // double myDouble = 5.25;
            // bool myBool = true;
            // Convert.ToString(myInt);          // convert int to string
            // Convert.ToDouble(myInt);          // convert int to double
            // Convert.ToInt32(myDouble);        // convert double to int
            // Convert.ToString(myBool);         // convert bool to string

            Console.WriteLine("===== Operators   =====");
            // int c = 1;
            // // in-line conditional operator
            // string message = (c == 1) ? "Car" : "Boat";

            Console.WriteLine("===== For         =====");
            // string[] names = new string[] {"aaa", "bbb", "ccc", "ddd"};
            // for (int i = 0; i < 10; i++) {
            //     // Console.WriteLine(i);
            //     if(i == 7) {
            //         Console.WriteLine("Found seven!");
            //         break;
            //     }
            // foreach(string name in names) {
            //     Console.WriteLine(name);
            // }
            Console.WriteLine("===== Arrays      =====");
            // int[] nums = new int[5];
            // int[] numbers = new int[] {4, 8, 15, 23, 42};

            // for (int i = 0; i < numbers.Length; i++) {
            //     Console.WriteLine(i);
            // }

            Console.WriteLine("===== SimpleMethod =====");
            // HelloWorld();
            // DisplayMessage(ReverseString("Hello World"));
            
            Console.WriteLine("===== Recursion    =====");
            // int fibonacci = Fibonacci(29);
            // Console.Write(fibonacci);

            Console.WriteLine("===== While        =====");
            // bool displayMenu = true;
            // while (displayMenu)
            // {
            //     displayMenu = MainMenu();    
            // }

            Console.WriteLine("===== String       =====");
            // string myString0 = String.Format("{0} = {1}", "First", "Second");
            // Console.WriteLine(myString0);
            // string myString1 = String.Format("{0:C}", 123.45);
            // Console.WriteLine(myString1);
            // string myString2 = String.Format("{0:N}", 1234567);
            // Console.WriteLine(myString2);
            // string myString3 = String.Format("{0:P}", .123);
            // Console.WriteLine(myString3);
            // StringBuilder myString4 = new StringBuilder();
            // for (int i = 0; i < 100; i++)
            // {
            //     myString4.Append("--");
            //     myString4.Append(i);
            // }
            // Console.WriteLine(myString4);

            Console.WriteLine("===== DatesAndTimes =====");
            // DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToShortTimeString());
            // Console.WriteLine(myValue.ToLongTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            // TimeSpan myAge = DateTime.Now.Subtract(DateTime.Parse("7/13/1993"));
            // Console.WriteLine(myAge.TotalHours);
            
            Console.WriteLine("===== SimpleClasses =====");
            // Car myCar = new Car();
            // myCar.Make = "Oldsmobile";
            // myCar.Model = "Cutlas Supreme";
            // myCar.Year = 1986;
            // myCar.Color = "Silver";
            // Console.WriteLine("{0} {1} {2} {3}", 
            //     myCar.Make, 
            //     myCar.Model, 
            //     myCar.Year, 
            //     myCar.Color);
            // // decimal value = DetermineMarketValue(myCar);
            // // Console.WriteLine("{0:C},", value);
            // Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.WriteLine("===== ObjectLifeTime =====");
            // Car myCar = new Car("Oldsmobile", "Cutlas Supreme", 1986, "Silver");
            // Car.MyMethod();
            Car Ford = new Car("Oldsmobile", "Cutlas Supreme", 1986, "Silver");
        }
        private static char [] ReverseString(string message) {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return messageArray;
        }
        private static void DisplayMessage(char [] messageArray) {
            foreach(char item in messageArray) {
                Console.Write(item);
            }
        }
        private static int Fibonacci(int n) {
            if(n <= 1) return n;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        private static bool MainMenu() {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1") {
                PrintNumbers();
                return true;
            }
            else if (result == "2") {
                GuessingGame();
                return true;
            }
            else if (result == "3") {
                return false;
            }
            else {
                return true;
            }
        }
        private static void PrintNumbers() {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1) {
                Console.Write(counter + "-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame() {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do {
                Console.Write("Choose a number between 1 - 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString()) {
                    Console.WriteLine("Correct! It took {0} guesses", guesses);
                    incorrect = false;
                }
                else Console.WriteLine("Wrong! Guess {0}", guesses);
            } while (incorrect);
            Console.ReadLine();
        }
    }
    class Car {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year {get; set; }
        public string Color {get; set; }

        public Car(string make, string model, int year, string color) {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public decimal DetermineMarketValue() {
            decimal carValue;
            if (Year > 1990) carValue = 10000;
            else carValue = 2000;
            return carValue;
        }
    }
}
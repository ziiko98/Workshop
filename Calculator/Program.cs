namespace CalculatorProject
{
    class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();  // Clears the console before starting over.
                double num1, num2, result;
                string answer;
                Console.WriteLine("------------------");
                Console.WriteLine("My Calculator App");
                Console.WriteLine("------------------");
                Console.WriteLine("Enter your first number:");
                // TryParse prevents crashes if user writes a letter.
                if (!double.TryParse(Console.ReadLine(), out num1)) continue; 
                Console.WriteLine("Enter your second number:");
                if (!double.TryParse(Console.ReadLine(), out num2)) continue;
                Console.WriteLine("Select an operation: "); 
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                answer = Console.ReadLine();
               
                // If statement to check which operator user selects.
                if (answer == "+")
                {
                    result = Calculator.Add(num1, num2);
                }
                else if (answer == "-")
                {
                    result = Calculator.Subtract(num1, num2);
                }
                else if (answer == "*")
                {
                    result = Calculator.Multiply(num1, num2);
                }
                else if (answer == "/")
                {
                    result = Calculator.Divide(num1, num2);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey(); // Waits for the user to press a key before clearing the console. 
                    continue;
                }

                Console.WriteLine("The result is " + result);
                {
                    // Use a while loop to run the program over again.     
                    Console.WriteLine("Do you want to calculate again? (y/n)");
                    string again = Console.ReadLine().ToLower();
                    if
                        (again == "n")
                    {  Console.WriteLine("Thank you for using my calculator!");
                        break; // Closes the program.
                    }

                }
            }
        }
    }
}

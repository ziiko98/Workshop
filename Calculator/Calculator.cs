namespace CalculatorProject;

public class Calculator 
    // I used a class to separate logic from the main program. 
{
    // The methods are Add, Subtract, Multiply and Divide. Parameters: num1 and num2. 
    // The parameters are values that passed into a method. 
   public static double Add(double num1, double num2)  
    {
        return num1 + num2;  // Return is used to send back the result.
    }
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    public static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        { 
            Console.WriteLine("You cannot divide by zero."); 
            return 0; 
        } 
        return num1 / num2;
    }
}
using System;

namespace Lab1
{
    public class ExceptionExample
    {
        public static void Divide(int x, int y)
        {
            try
            {
                int result = x / y;
                Console.WriteLine($"Result of division: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Division operation completed.");
            }
        }
    }
}

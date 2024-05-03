namespace Lab1
{
    delegate int MathOperation(int x, int y);

    public class MathOperations
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}

using Lab1;

class Program
{
    static void Main(string[] args)
    {
        //Constructor
        Console.WriteLine("Constructor");
        Person person = new Person("Ram", 24);
        person.DisplayInfo();

        //Inheritance
        Console.WriteLine("\nInheritance");
        Dog dog = new Dog();
        dog.Eat();  
        dog.Bark();

        //Polymorphism
        Console.WriteLine("\nPolymorphism");
        Shape[] shapes = { new Circle(), new Rectangle() };
        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        //Interface
        Console.WriteLine("\nInterface");
        IVehicle[] vehicles = { new Car(), new Bicycle() };
        foreach (var vehicle in vehicles)
        {
            vehicle.Accelerate();
            vehicle.Brake();
        }

        //Delegates
        Console.WriteLine("\nDelegates");
        MathOperation add = MathOperations.Add;
        MathOperation subtract = MathOperations.Subtract;

        int resultAdd = add(10, 5);
        int resultSubtract = subtract(10, 5);

        Console.WriteLine("addition: " + resultAdd);
        Console.WriteLine("subtraction: " + resultSubtract);

        //LINQ
        Console.WriteLine("\nLINQ");
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };       
        LINQExample.PerformLINQOperations(numbers);

        //Exception
        Console.WriteLine("\nException");
        ExceptionExample.Divide(10, 0);
    }
}
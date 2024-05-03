namespace Lab1
{
    interface IVehicle
    {
        void Accelerate();
        void Brake();
    }

    class Car : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Car accelerates with the engine.");
        }

        public void Brake()
        {
            Console.WriteLine("Car brakes using the brake pedal.");
        }
    }

    class Bicycle : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Bicycle accelerates by pedaling.");
        }

        public void Brake()
        {
            Console.WriteLine("Bicycle brakes using hand brakes.");
        }
    }

}
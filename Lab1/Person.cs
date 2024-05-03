namespace Lab1
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}

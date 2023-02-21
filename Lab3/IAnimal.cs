namespace Lab3
{
    internal interface IAnimal
    {
        int Age { get; set; }
        string Color { get; set; }
        string Name { get; set; }

        int Height { get; set; }

        void Cry();

        void Eat();
    }
}
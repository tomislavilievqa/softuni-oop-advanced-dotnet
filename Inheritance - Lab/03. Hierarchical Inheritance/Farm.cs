namespace _03._Hierarchical_Inheritance
{
    public class Farm
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
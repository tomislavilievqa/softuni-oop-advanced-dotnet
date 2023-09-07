namespace _04._Random_List
{
    public class CustomRandomList
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList(new string[] { "zdrasti", "chao", "pesho", "gosho", "stamat" });

            Console.WriteLine(list.Count);

            Console.WriteLine(list.RandomString());

            Console.WriteLine(list.RandomString());

            Console.WriteLine(list.Count);


        }
    }
}
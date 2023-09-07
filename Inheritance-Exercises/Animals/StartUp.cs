namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> output = new List<Animal>();
                      
            
            while (true) 
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] animalDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = animalDetails[0];
                int age = int.Parse(animalDetails[1]);
                string gender = animalDetails[2];

                try
                {
                    switch (animalType?.ToLower())
                    {
                        case "tomcat":
                            output.Add(new Tomcat(name, age));
                            break;

                        case "kitten":
                            output.Add(new Kitten(name, age));
                            break;

                        case "cat":
                            output.Add(new Cat(name, gender, age));
                            break;

                        case "frog":
                            output.Add(new Frog(name, gender, age));
                            break;

                        case "dog":
                            output.Add(new Dog(name, gender, age));
                            break;
                        default:
                            throw new Exception("Invalid input!");
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);                    
                }
            }
            foreach(var animal in output)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}

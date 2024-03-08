namespace GenericAnimalClass;
public class Animal <T>
{
    public T data;
    public Animal (T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
    public T getAnimal()
    {
        return data;
    }
}

class Program
{
    static void Main(string[] args)
    {
       Animal<string> animalName = new Animal<string>("Snowman");
       Animal<string> animalHabitat = new Animal<string>("I like to eat hay");
       Animal<bool> endangered = new Animal<bool>(false);
       Animal<bool> extinct = new Animal<bool>(false);
       Animal<int> averageLifespan = new Animal<int>(30);
       Console.ReadKey();
    }
}


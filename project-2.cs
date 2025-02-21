var p1 = new Person ("Scott", "Hasselman", new DateOnly(2000,01,28));
var p2 = new Person ("abdallah", "khalaf", new DateOnly(1998,01,28));

p1.Pets.Add(new Dog("Fred"));
p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1,p2];

foreach(var person in people)
{
    Console.WriteLine($"{person}");
    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"       {pet}");
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public  DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"Human {First} {Last} {Birthday}";
    }
}

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract string MakeNoise();
    public override string ToString()
    {
        return $"{First} and i am a {GetType().Name} and i {MakeNoise()}";
    }
}

public class Cat(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "meow";
}

public class Dog(string firstname) : Pet(firstname)
{
    public override string MakeNoise() => "bark";
}

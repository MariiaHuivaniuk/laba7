using System;

class Person
{
    private string name;
    private DateTime birthYear;

    public string Name
    {
        get { return name; }
    }

    public DateTime BirthYear
    {
        get { return birthYear; }
    }

   

    public Person(string name, DateTime birthYear)
    {
        this.name = name;
        this.birthYear = birthYear;
    }
    public Person()
    {
       
    }
    public int Age()
    {
        return DateTime.Now.Year - birthYear.Year;
    }

    public void Input()
    {
        Console.Write("name= ");
        name = Console.ReadLine();
        Console.Write("birth year= ");
        birthYear = DateTime.Parse(Console.ReadLine());
    }

    public void ChangeName()
    {
        Console.Write("new name= ");
        name = Console.ReadLine();
    }

    public override string ToString()
    {
        return $"Name: {name}, Birth Year: {birthYear.Year}";
    }

    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public static bool operator ==(Person person1, Person person2)
    {
        return person1.name == person2.name;
    }

    public static bool operator !=(Person person1, Person person2)
    {
        return person1.name != person2.name;
    }
}

class Program
{
    static void Main()
    {
        Person[] people = new Person[6];

        for (int i = 0; i < 6; i++)
        {
            people[i] = new Person();
            people[i].Input();
        }

        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age()}");
            if (person.Age() < 16)
            {
                person.ChangeName();
            }
        }

        Console.WriteLine("\nІнформація про всіх людей:");
        foreach (var person in people)
        {
            person.Output();
        }

        Console.WriteLine("\nЛюди з однаковими іменами:");
        for (int i = 0; i < people.Length; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                if (people[i] == people[j])
                {
                    Console.WriteLine($"1. {people[i]}");
                    Console.WriteLine($"2. {people[j]}\n");
                }
            }
        }
    }
}
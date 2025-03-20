using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public static class ArrayOperations
{
    public static void SortByName(List<Person> people)
    {
        people.Sort((x, y) => string.Compare(x.Name, y.Name));
    }

    public static List<Person> FilterByAge(List<Person> people, int maxAge)
    {
        List<Person> result = new List<Person>();
        foreach (var person in people)
        {
            if (person.Age < maxAge)
            {
                result.Add(person);
            }
        }
        return result;
    }

    public static double CalculateAverageAge(List<Person> people)
    {
        if (people.Count == 0) return 0;

        double totalAge = 0;
        foreach (var person in people)
        {
            totalAge += person.Age;
        }
        return totalAge / people.Count;
    }

    public static List<Person> GenerateRandomPeople(int count)
    {
        string[] names = { "Alice", "Inna", "Lesha", "Vova", "Eva" };
        var random = new Random();
        List<Person> people = new List<Person>();

        for (int i = 0; i < count; i++)
        {
            string name = names[random.Next(names.Length)];
            int age = random.Next(18, 72);
            people.Add(new Person(name, age));
        }

        return people;
    }
}

public static class StringProcessor
{
    public static string ConcatenateNames(List<Person> people)
    {
        string result = "";
        for (int i = 0; i < people.Count; i++)
        {
            result += people[i].Name;
            if (i < people.Count - 1)
            {
                result += ", ";
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = ArrayOperations.GenerateRandomPeople(10);
        Console.WriteLine("Сгенерированные люди:");
        foreach (var person in people)
        {
            Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
        }

        ArrayOperations.SortByName(people);
        Console.WriteLine("\nСортировка по имени:");
        foreach (var person in people)
        {
            Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
        }

        Console.WriteLine($"\nСредний возраст: {ArrayOperations.CalculateAverageAge(people)}");

        List<Person> filteredPeople = ArrayOperations.FilterByAge(people, 25);
        Console.WriteLine("\nЛюди младше 25 лет:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
        }

        Console.WriteLine($"\nОбъединенные имена: {StringProcessor.ConcatenateNames(people)}");
    }
}
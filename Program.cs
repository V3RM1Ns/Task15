namespace Task15;

class Program
{
    static void Main(string[] args)
    {
      
        Person[] people = new Person[]
        {
            new Person { Name = "Ali", Surname = "Mammadov", Age = 30 },
            new Person { Name = "Leyla", Surname = "Hasanova", Age = 25 },
            new Person { Name = "Murad", Surname = "Aliyev", Age = 35 },
        };
        PersonSorter.SortByAge(people);
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} {person.Surname}, Age: {person.Age}");
        }
    }
}
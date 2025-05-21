namespace Task15;

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[]
        {
            new Person { Name = "Ali", Surname = "Aliyev", Age = 30 },
            new Person { Name = "Leyla", Surname = "Aliyeva", Age = 25 },
            new Person { Name = "Murad", Surname = "Aliyev", Age = 35 },
        };
        PersonSorter.SortByAge(people);
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} {person.Surname}, Age: {person.Age}");
        }
        
        
        
        Task task1 = new Task("asd", TaskStatus.Completed);
        Task task2 = new Task("as", TaskStatus.InProgress);
        Task task3 = new Task("a", TaskStatus.Cancelled);
        
        
        
        SimpleStringCollection simpleStringCollection = new SimpleStringCollection();
        simpleStringCollection.Strs(3);
        simpleStringCollection[0] = "asd";
        simpleStringCollection[1] = "as";
        simpleStringCollection[2] = "a"; 
        Console.WriteLine(simpleStringCollection[0]);
        
        
    }
}
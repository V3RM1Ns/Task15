public static class PersonSorter
{
    public static void SortByAge(Person[] people)
    {
        for (int i = 0; i < people.Length - 1; i++)
        {
            for (int j = 0; j < people.Length - i - 1; j++)
            {
                if (people[j] > people[j + 1])
                {
                    var temp = people[j];
                    people[j] = people[j + 1];
                    people[j + 1] = temp;
                }
            } 
        }
    }
}
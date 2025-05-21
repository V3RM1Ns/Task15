namespace Task15;

public class SimpleStringCollection
{
    private string[] list;

    public void Strs(int n)
    {
        list = new string[n];
    }
    public string this[int index]
    {
        get
        {
            return list[index];
        }
        set
        {
            if (index < 0 || index >= list.Length)
                Console.WriteLine("Index is out of range.");
            list[index] = value;
        }
    }

}
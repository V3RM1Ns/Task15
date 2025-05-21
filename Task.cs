namespace Task15;

public class Task
{
    public string Title { get; set; }
    public TaskStatus Status { get; set; }

    public Task(string title, TaskStatus status)
    {
        Title=title;
        Status=status;
    }
}
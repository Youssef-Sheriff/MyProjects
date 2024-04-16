namespace TodoList;

class Program
{
     private static readonly string FilePath = "G:\\MyProjects\\TodoList\\todo_data.txt";
    private static readonly List<string> Tasks = File.ReadAllLines(FilePath).ToList();

    private static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the To-Do List App!");
            Console.WriteLine("1. Add Task\n2. Delete Task\n3. View Tasks\n4. Exit");
            Console.Write("Enter your choice: ");

            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    DeleteTask();
                    break;
                case 3:
                    ViewTask();
                    break;
                case 4:
                    Console.WriteLine("\nThank u for using my app. :)");
                    File.WriteAllLines(FilePath, Tasks);
                    return;
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }

            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();
        } while (true);
    }

    private static void AddTask()
    {
        Console.Write("Enter task description: ");
        var task = Console.ReadLine();
        Tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }

    private static void DeleteTask()
    {
        ViewTask();
        Console.Write("Enter task number to delete: ");
        var choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= Tasks.Count)
        {
            Tasks.RemoveAt(choice - 1);
            Console.WriteLine("Task deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }

    private static void ViewTask()
    {
        Console.WriteLine("Your Tasks:");
        for (var i = 0; i < Tasks.Count; i++) Console.WriteLine($"\t{i + 1}. {Tasks[i]}");
    }
}
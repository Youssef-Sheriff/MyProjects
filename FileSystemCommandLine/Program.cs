namespace FileSystemCommandLine;

class Program
{
    static void Main(string[] args)
    {
        /*
            >> File System Command Line <<
            
            1. list files & directories: list [path]
            2. print file & directory info: info [path]
            3. create directory: mkdir [path]
            4. remove directory: remove [path]
            5. read file content: read [path]
            
         */
        do
        {
            Console.Clear();
            Console.Write(">> ");
            var input = Console.ReadLine().Trim();
            var whiteSpaceIndex = input.IndexOf(' ');
            if (input == "exit")
            {
                return;
            }
            var command = input.Substring(0, whiteSpaceIndex);
            var path = input.Substring(whiteSpaceIndex + 1);

            switch (command)
            {

                case "list":
                    // print all the folders and files in path
                    foreach (var directory in Directory.GetDirectories(path))
                        Console.WriteLine($"\t[Dir]: {directory}");

                    Console.WriteLine("\t~~~~~~~~~~~~~~~~~~~~~~~~~~");

                    foreach (var directory in Directory.GetFiles(path))
                        Console.WriteLine($"\t[File]: {directory}");
                    break;

                case "info":
                    // check first if folder or file is exist or not
                    if (Directory.Exists(path))
                    {
                        var dirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Type: Directory");
                        Console.WriteLine($"Created at: {dirInfo.CreationTime}");
                        Console.WriteLine($"Last modify: {dirInfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);
                        Console.WriteLine("Type: File");
                        Console.WriteLine($"Created at: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last modify: {fileInfo.LastWriteTime}");
                        Console.WriteLine($"File Size: {(fileInfo.Length / 1000) / 1000} MB");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, this path not found!");
                        Console.WriteLine("\n\rPress Enter to continue ..");
                        Console.ReadLine();
                    }

                    break;
                case "mkdir":
                    Directory.CreateDirectory(path);
                    Console.Write("Directory successfully created");
                    Console.ReadLine();

                    break;
                case "remove":
                    if (Directory.Exists(path))
                        Directory.Delete(
                            path); // can send second parameter with ture to delete director with any files in

                    else if (File.Exists(path))
                        File.Delete(path);

                    Console.Write("removed successfully");
                    Console.ReadLine();
                    break;
                case "read":
                    if (File.Exists(path))
                    {
                        foreach (var lines in File.ReadAllText(path))
                        {
                            Console.Write(lines);
                        }
                    }
                    Console.WriteLine("\r\npress enter to continue..");
                    Console.ReadLine();
                    break;
                case "exit":
                    goto end;
                default:
                    Console.WriteLine($"{command} command not support.");
                    Console.WriteLine("\n\rpress enter to continue..");
                    Console.ReadLine();
                    break;
            }
        } while (true);

        end: ;

    }
}
using System.Data;
using System.Diagnostics;

using System.Text;

namespace PasswordManager;

class Program
{
    private static readonly Dictionary<string, string> SavedPasswords = new();
    private static string  filePath = "G:\\MyProjects\\PasswordManager\\passwords.txt";
    static void Main(string[] args)
    {
        int[] arr = { };
        int x = arr.Length;
        
        // websiteName = Password 
        ReadPasswords();
        while (true)
        {
            // Console.Clear();
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. List all passwords");
            Console.WriteLine("2. Add / Change Password");
            Console.WriteLine("3. Get Password");
            Console.WriteLine("4. Delete Password");
            Console.WriteLine();

            int selectedOption = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (selectedOption == 1)
                    ListAllPassword();
                else if (selectedOption == 2)
                    AddOrChangePassword();
                else if (selectedOption == 3)
                    GetPassword();
                else if (selectedOption == 4)
                    DeletePassword();
                else
                    Console.WriteLine("Invalid Option...");

                Console.WriteLine("------------------------------");
            } while (selectedOption <= 0 && selectedOption > 4);
            

        }
    }

    private static void ReadPasswords()
    {
        if (File.Exists(filePath)) ;
        var passwordLines = File.ReadAllText(filePath);

        foreach (var line in passwordLines.Split(Environment.NewLine))
        {
            if (!string.IsNullOrEmpty(line))
            {
                var equalIndex = line.IndexOf('=');
                string website = line.Substring(0, equalIndex);
                string password = line.Substring(equalIndex + 1);
                
                SavedPasswords.Add(website, Encryption.Decrypt(password));
            }
        }
    }
    private static void SavePasswords()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var password in SavedPasswords)
            sb.Append($"{password.Key} = {Encryption.Encrypt(password.Value)}");
        File.WriteAllText(filePath, sb.ToString());
        
    }

    private static void DeletePassword()
    {
        Console.Write($"Enter website name: ");
        string? website = Console.ReadLine();

        if (SavedPasswords.ContainsKey(website))
            SavedPasswords.Remove(website);
        else
            Console.WriteLine($"{website} not found");

        SavePasswords();
    }

    private static void GetPassword()
    {
        Console.Write($"Enter website name: ");
        string? website = Console.ReadLine();

        if (SavedPasswords.ContainsKey(website))
            Console.WriteLine($"{website}'s password = {SavedPasswords[website]}");
        else
            Console.WriteLine($"{website} not found");
        
        
    }

    private static void AddOrChangePassword()
    {
        Console.Write($"Enter website name: ");
        string? website = Console.ReadLine();
        Console.Write($"Enter {website} password ");
        string? password = Console.ReadLine();

        if (SavedPasswords.ContainsKey(website))
            SavedPasswords[website] = password;
        else
            SavedPasswords.Add(website, password);
        SavePasswords();
    }

    private static void ListAllPassword()
    {
        foreach (var password in SavedPasswords)
        {
            Console.WriteLine($"{password.Key} = {password.Value}");
        }
    }
}
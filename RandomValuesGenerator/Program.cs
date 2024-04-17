using System.Text;

namespace Random_Values_Generator;

class Program
{
    static void Main(string[] args)
    {
        /* [ Random Values Generator ]
        * Ask the user to select an option:
        * [1] Generate random number [2] Generate random string
        * If user selected to generate random number: Generate random number between 1000 and 9999
        * If user selected to generate random string: Generate random string with 16 characters length
        *
        * Features
        * If user selected to generate random number, ask him to enter minimum & maximum values
        * If user selected to generate random string, ask him to enter the string length
        * If user selected to generate random string, ask him to select buffer options as follows:
        [1] Include capital letters? (yes/no)
        [2] Include small letters? (yes/no)
        [3] Include numbers? (yes/no)
        [4] Include symbols? (yes/no)
        */
        
        while (true)
        {
            
            Console.Clear();
            Console.WriteLine(" -- Random Values Generator App -- ");
            Console.WriteLine("[1] Generate random number  [2] Generate random string");
            Console.Write("Please select an option: ");
            var selectOption = Console.ReadLine();
            switch (selectOption)
            {
                case "1":
                    Console.Write("Enter minimum value: ");
                    var minValue = int.Parse(Console.ReadLine());
                    Console.Write("Enter maximum value: ");
                    var maxValue = int.Parse(Console.ReadLine());
                    char choice;
                    do
                    {
                        var res = GenerateRandomNumber(minValue, maxValue);
                        Console.WriteLine($"Random Number: {res}");
                        Console.Write("\nanother number? (y/n): ");
                        choice = Convert.ToChar(Console.ReadLine().ToLower());
                    } while (choice!='n');
                    break;
                
                case "2":
                    const string CAPITAL = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    const string SMALL = "abcdefghijklmnopqrstuvwxyz";
                    const string NUMBERS = "0123456789";
                    const string SYMBOLS = "!#$%&()*+,-/@[]^_{}~";
                    
                    Console.Write("Enter the string length: ");
                    var strLength = int.Parse(Console.ReadLine());
                    
                    Console.Write("[1] Include capital letters? (y/n): ");
                    char capital = Convert.ToChar(Console.ReadLine());
                    
                    Console.Write("[2] Include small letters? (y/n): ");
                    char small = Convert.ToChar(Console.ReadLine());
                    
                    Console.Write("[3] Include numbers? (y/n): ");
                    char numbers = Convert.ToChar(Console.ReadLine());
                    
                    Console.Write("[4] Include symbols? (y/n): ");
                    char symbols = Convert.ToChar(Console.ReadLine());

                    StringBuilder Buffer = new StringBuilder();
                    
                    if (capital == 'y')
                    {
                        Buffer .Append(CAPITAL);
                    }
                    if (small == 'y')
                    {
                        Buffer .Append(SMALL);
                    }
                    if (numbers == 'y')
                    {
                        Buffer .Append(NUMBERS);
                    }
                    if (symbols == 'y')
                    {
                        Buffer .Append(SYMBOLS);
                    }

                    do
                    {
                        GenerateRandomString(strLength, Buffer);
                        Console.Write("\nanother string? (y/n): ");
                        choice = Convert.ToChar(Console.ReadLine().ToLower());
                    } while (choice!='n');
                    break;
                
                case "exit":
                case "0": 
                    Console.Clear();
                    Console.WriteLine("\nThanks for using my app :)");
                    return;
                
            }
        }
    }

    


    private static int GenerateRandomNumber(int min, int max)
    {
        Random rnd = new Random();
        var value = rnd.Next(Math.Min(min, max), Math.Max(min, max));
        return value;
    }
    
    private static void GenerateRandomString(int strLength, StringBuilder buffer)
    {
        StringBuilder randomString = new StringBuilder();
        Random rnd = new Random();
        while (randomString.Length<strLength)
        {
            var randomIndex = rnd.Next(0, buffer.Length - 1);
            randomString.Append(buffer[randomIndex]);
        }

        Console.WriteLine($"Random String: {randomString}");
    }
}
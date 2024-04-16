

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";


int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data.
string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
 switch (i)
 {
  case 0:
   animalSpecies = "dog";
   animalID = "d1";
   animalAge = "2";
   animalPhysicalDescription = "medium sized.";
   animalPersonalityDescription = "loves to play.";
   animalNickname = "lola";
   break;

  case 1:
   animalSpecies = "dog";
   animalID = "d2";
   animalAge = "9";
   animalPhysicalDescription = "large";
   animalPersonalityDescription = "cute and cuddly.";
   animalNickname = "loki";
   break;

  case 2:
   animalSpecies = "cat";
   animalID = "c3";
   animalAge = "1";
   animalPhysicalDescription = "small white";
   animalPersonalityDescription = "friendly";
   animalNickname = "Puss";
   break;

  case 3:
   animalSpecies = "cat";
   animalID = "c4";
   animalAge = "?";
   animalPhysicalDescription = "";
   animalPersonalityDescription = "";
   animalNickname = "";
   break;

  default:
   animalSpecies = "";
   animalID = "";
   animalAge = "";
   animalPhysicalDescription = "";
   animalPersonalityDescription = "";
   animalNickname = "";
   break;

 }
 ourAnimals[i, 0] = "ID #: " + animalID;
 ourAnimals[i, 5] = "Nickname: " + animalNickname;
 ourAnimals[i, 1] = "Species: " + animalSpecies;
 ourAnimals[i, 2] = "Age: " + animalAge;
 ourAnimals[i, 3] = "Physical Description: " + animalPhysicalDescription;
 ourAnimals[i, 4] = "Personality Description: " + animalPersonalityDescription;
}

do
{
 Console.Clear();

 Console.WriteLine("Welcome to the PetFriends app. Your main menu options are:");
 Console.WriteLine(@" 1. List all of our current pet information
 2. Add a new animal friend to the ourAnimals array
 3. Ensure animal ages and physical descriptions are complete
 4. Ensure animal nicknames and personality descriptions are complete
 5. Edit an animal's age
 6. Edit an animal's personality description
 7. Display all cats with a specified characteristic
 8. Display all dogs with a specified characteristic");

 readResult = Console.ReadLine();
 if (readResult != null)
  menuSelection = readResult;
 switch (menuSelection)
 {
  case "1":
   for (int i = 0; i < maxPets; i++)
   {
    if (ourAnimals[i, 0] != "ID #: ") // if the ID is not empty then display the animal information
    {
     Console.WriteLine();
     for (int j = 0; j < 6; j++)
     {
      Console.WriteLine(ourAnimals[i, j]);
     }
    }
   }

   Console.WriteLine("\n\rPress the Enter key to continue");
   readResult = Console.ReadLine();
   break;
  case "2": // add new animal if u have a free place
   string anotherAnimal = "y";
   int noOfPets = 0;

   for (int i = 0; i < maxPets; i++)
    if (ourAnimals[i, 0] != "ID #: ")
     noOfPets++;

   if (noOfPets < maxPets)
    Console.WriteLine($"You have {maxPets - noOfPets} free places for new animals");


   while (anotherAnimal == "y" && noOfPets < maxPets)
   {
    bool validEntry;

    do
    {
     Console.WriteLine("\n\rEnter the species of the animal (dog or cat): ");
     readResult = Console.ReadLine();
     if (readResult != null)
      animalSpecies = readResult.ToLower().Trim();
     validEntry = animalSpecies is "dog" or "cat";

    } while (!validEntry);
    // generate id 

    animalID = animalSpecies.Substring(0, 1) + (noOfPets + 1).ToString();

    // animal age
    do
    {
     int petAge;
     Console.WriteLine("Enter the age of the animal or ? if unknown: ");
     readResult = Console.ReadLine();
     if (readResult != null)
      animalAge = readResult;
     validEntry = int.TryParse(animalAge, out petAge) || animalAge == "?";
    } while (!validEntry);

    do
    {
     Console.WriteLine("Enter the physical description of the animal (size, color, gender, weight): ");
     readResult = Console.ReadLine();
     if (readResult != null)
     {
      animalPhysicalDescription = readResult;
      if (animalPhysicalDescription == "")
      {
       animalPhysicalDescription = "unknown";
      }
     }
    } while (animalPhysicalDescription == "");
    // animal personality

    do
    {
     Console.WriteLine("Enter the personality description of the animal: ");
     Console.ReadLine();
     if (readResult != null)
     {
      animalPersonalityDescription = readResult.ToLower();
      if (animalPersonalityDescription == "")
      {
       animalPersonalityDescription = "unknown";
      }
     }
    } while (animalPersonalityDescription == "");

    // animal nickname
    do
    {
     Console.WriteLine("Enter the nickname of the animal: ");
     readResult = Console.ReadLine();
     if (readResult != null)
     {
      animalNickname = readResult.ToLower();
      if (animalNickname == "")
      {
       animalNickname = "unknown";
      }
     }
    } while (animalNickname == "");

    // add animal to the array

    ourAnimals[noOfPets, 0] = "ID #: " + animalID;
    ourAnimals[noOfPets, 1] = "Species: " + animalSpecies;
    ourAnimals[noOfPets, 2] = "Age: " + animalAge;
    ourAnimals[noOfPets, 3] = "Physical Description: " + animalPhysicalDescription;
    ourAnimals[noOfPets, 4] = "Personality Description: " + animalPersonalityDescription;
    ourAnimals[noOfPets, 5] = "Nickname: " + animalNickname;

    // increment the number of pets
    noOfPets++;

    // ask if the user wants to add another animal
    if (noOfPets < maxPets)
    {
     // another pet?
     Console.WriteLine("Do you want to enter info for another pet (y/n)");
     do
     {
      readResult = Console.ReadLine();
      if (readResult != null)
      {
       anotherAnimal = readResult.ToLower();
      }

     } while (anotherAnimal != "y" && anotherAnimal != "n");
    }
   }

   if (noOfPets >= maxPets)
   {
    Console.WriteLine("You have reached the maximum number of pets");
    Console.WriteLine("\n\rPress the Enter key to continue");
    Console.ReadLine();
    
   }

   break;

  case "3":
  // Ensure ages and physical descriptions are complete
  // Console.WriteLine("Challenge Project - please check back soon to see progress.");
  // Console.WriteLine("Press the Enter key to continue.");
  // readResult = Console.ReadLine();
  
  // code update ..
  for (int i = 0; i < maxPets; i++)
  {

   if (ourAnimals[i, 0] == "ID #: ") // empty animal 
   {
    continue;
   }
   if (ourAnimals[i, 2].EndsWith("?"))
   {
    bool validEntry;
    int petAge;
    do
    {
     Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
     readResult = Console.ReadLine();
     if (readResult != null)
      animalAge = readResult;
     validEntry = int.TryParse(animalAge, out petAge) && animalAge != "0";
    } while (!validEntry);

    animalAge = $"Age: {petAge}";
   }
   ////
   if (ourAnimals[i, 3] .EndsWith(" "))
   {    
    bool validEntry;

    do
    {
     Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");
     readResult = Console.ReadLine();
     animalPhysicalDescription = readResult?.Trim(); 

     validEntry = !string.IsNullOrEmpty(animalPhysicalDescription) && !int.TryParse(animalPhysicalDescription, out _);
     
    } while (!validEntry);
    animalPhysicalDescription = $"Physical Description: {animalPhysicalDescription}";
   }
   ourAnimals[i, 2] = animalAge;
   ourAnimals[i, 3] = animalPhysicalDescription;
  }

  Console.WriteLine("Age and physical description fields are complete for all of our friends.");
  Console.WriteLine("\n\rPress the Enter key to continue.");
  Console.ReadLine();
  break;

  case "4":
   // Ensure animal nicknames and personality descriptions are complete
   // Console.WriteLine("Challenge Project - please check back soon to see progress.");
   // Console.WriteLine("Press the Enter key to continue.");
   // code update
   
   for (int i = 0; i < maxPets; i++)
   {
    if (ourAnimals[i, 0] == "ID #: ") // empty animal 
    {
     continue;
    }
    if (ourAnimals[i, 5] .EndsWith(" "))
    {    
     bool validEntry;

     do
     {
      Console.WriteLine($"Enter Enter a nickname for {ourAnimals[i, 0]}");
      readResult = Console.ReadLine();
      animalNickname = readResult?.Trim(); 

      validEntry = !string.IsNullOrEmpty(animalNickname) && !int.TryParse(animalNickname, out _);
     
     } while (!validEntry);
     animalNickname = $"Physical Description: {animalNickname}";
    }
    
    if (ourAnimals[i, 4] .EndsWith(" "))
    {    
     bool validEntry;
     
     do
     {
      Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)");
      readResult = Console.ReadLine();
      animalPersonalityDescription = readResult?.Trim(); 

      validEntry = !string.IsNullOrEmpty(animalPersonalityDescription) && !int.TryParse(animalPersonalityDescription, out _);
     
     } while (!validEntry);
     animalPersonalityDescription = $"Physical Description: {animalPersonalityDescription}";
    }
    ourAnimals[i, 4] = animalPersonalityDescription;
    ourAnimals[i, 5] = animalNickname;
   }
   
   Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
   Console.WriteLine("\n\rPress the Enter key to continue.");
   Console.ReadLine();
   
   break;

  case "5":
   // Edit an animal’s age" );
   Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
   Console.WriteLine("Press the Enter key to continue.");
   readResult = Console.ReadLine();
   break;

  case "6":
   // Edit an animal’s personality description");
   Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
   Console.WriteLine("Press the Enter key to continue.");
   readResult = Console.ReadLine();
   break;

  case "7":
   // Display all cats with a specified characteristic
   Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
   Console.WriteLine("Press the Enter key to continue.");
   readResult = Console.ReadLine();
   break;

  case "8":
   // Display all dogs with a specified characteristic
   Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
   Console.WriteLine("Press the Enter key to continue.");
   readResult = Console.ReadLine();
   break;
  default:
   break;
 }
} while (menuSelection != "exit" && menuSelection != "0");
Console.Clear();
Console.WriteLine("\nThank you for using the PetFriends app. Goodbye.");


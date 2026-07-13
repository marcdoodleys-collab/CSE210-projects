using System;


// Programme principal
class Program
{

    static void Main(string[] args)
    {

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();


        string choice = "";


        while (choice != "5")
        {

            Console.WriteLine();
            Console.WriteLine("Journal Program");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.Write("Select an option: ");

            choice = Console.ReadLine();



            if (choice == "1")
            {
                Entry entry = new Entry();


                entry._date = DateTime.Now.ToShortDateString();


                entry._promptText =
                    promptGenerator.GetRandomPrompt();


                Console.WriteLine();

                Console.WriteLine(entry._promptText);

                Console.Write("> ");

                entry._entryText = Console.ReadLine();


                journal.AddEntry(entry);
            }



            else if (choice == "2")
            {
                journal.DisplayAll();
            }



            else if (choice == "3")
            {
                journal.LoadFromFile("journal.txt");
            }



            else if (choice == "4")
            {
                journal.SaveToFile("journal.txt");
            }



            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }



            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }

    }
}
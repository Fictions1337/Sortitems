using System.Collections.Generic;
using System.IO;
using static System.Console;
class Program
{
    public static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("input.txt");
        foreach (string line in lines)
        {
            string[] split = line.Split(';');
            entries.Add(new Entry(split[0], split[1], float.Parse(split[2])));                        
        }
        WriteLine("How do you wish to sort the file?");
        WriteLine("1) Sort by Name");
        WriteLine("2) Sort by Description");
        WriteLine("3) Sort by Price" + '\n');
        WriteLine("Enter the option number:");
        string userInput = ReadLine();
        switch (userInput)
        {
            case "1":
                WriteLine("Please choose in which order the Names will be sorted:");
                WriteLine("1) Ascending");
                WriteLine("2) Descending" + '\n');
                userInput = ReadLine();
                switch(userInput)
                {
                    case "1":
                        entries.Sort((x,y) => {return x.name.CompareTo(y.name); });
                        WriteSortedList();
                        break;
                    case "2":
                        entries.Sort((x,y) => {return x.name.CompareTo(y.name); });
                        entries.Reverse();
                        WriteSortedList();
                        break;
                    default:
                        break;
                }               
                break;
            case "2":
                WriteLine("Please choose in which order the Descripions will be sorted:");
                WriteLine("1) Ascending");
                WriteLine("2) Descending" + '\n');
                userInput = ReadLine();
                switch(userInput)
                {
                    case "1":
                        entries.Sort((x,y) => {return x.description.CompareTo(y.description); });
                        WriteSortedList();
                        break;
                    case "2":
                        entries.Sort((x,y) => {return x.description.CompareTo(y.description); });
                        entries.Reverse();
                        WriteSortedList();
                        break;
                    default:
                        break;
                }               
                break;
            case "3":
                WriteLine("Please choose in which order the Names will be sorted:");
                WriteLine("1) Ascending");
                WriteLine("2) Descending" + '\n');
                userInput = ReadLine();
                switch(userInput)
                {
                    case "1":
                        entries.Sort((x,y) => {return x.price.CompareTo(y.price); });
                        WriteSortedList();
                        break;
                    case "2":
                        entries.Sort((x,y) => {return x.price.CompareTo(y.price); });
                        entries.Reverse();
                        WriteSortedList();
                        break;
                    default:
                        break;
                }               
                break;
        }
    }
    static void WriteSortedList()
    {
        using (StreamWriter writer = new StreamWriter("sorted.txt"))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.name + ';' + entry.description + ';' + entry.price);
            }
        }
    }
}


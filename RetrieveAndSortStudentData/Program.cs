using System.Collections;
using System.Collections.Generic;

class ReadFromFile
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\stefan_lica\OneDrive - Dell Technologies\Desktop\FSD\InitSetup\RetrieveAndSortStudent.txt");
        string[] names = new string[lines.Length];
        int i = 0;
        foreach (string line in lines)
        {
            names[i++] = line.Substring(0, line.IndexOf(','));
            Console.WriteLine(line);
        }
        Array.Sort(lines);
        Console.WriteLine("Sorting entries:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        string val;
        Console.Write("Enter name: ");
        val = Console.ReadLine();

        foreach (string name in names)
        {
            if (name.Contains(val))
                Console.WriteLine("The student " + val + " has been found.");
        }

        Console.WriteLine("Complete student data:");
        foreach (string line in lines)
        {
            if(line.Contains(val))
                Console.WriteLine(line);
        }

        System.Console.ReadKey();
    }
}
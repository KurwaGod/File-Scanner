using System;
using System.IO;

namespace FileScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory path to scan:");
            string directoryPath = Console.ReadLine();

            Console.WriteLine("Enter the keyword to search for:");
            string keyword = Console.ReadLine();

            string[] files = Directory.GetFiles(directoryPath);

            Console.WriteLine("Scanning files in the directory...");
            foreach (string file in files)
            {
                string fileText = File.ReadAllText(file);

                if (fileText.Contains(keyword))
                {
                    Console.WriteLine("Found keyword in file: " + file);
                }
            }

            Console.WriteLine("Scan complete.");
        }
    }
}

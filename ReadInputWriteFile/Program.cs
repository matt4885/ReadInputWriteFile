using System;

namespace ReadInputWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            FileWriter.WriteToFile(userInput, @"C:\temp\myFile.txt");
        }
    }
}

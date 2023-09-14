// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;

Console.WriteLine("Hello, World!");


StreamReader file = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    Console.WriteLine(line);
}

file.Close();

string mioPath = "C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi";


try
{
    string newPath = mioPath + "\\Indirizzi.txt";

    if (!File.Exists(newPath))
    {
        StreamWriter newFile = File.CreateText(newPath);

        newFile.WriteLine("addio");

        newFile.Close();
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

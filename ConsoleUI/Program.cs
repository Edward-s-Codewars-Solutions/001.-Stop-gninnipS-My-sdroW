using System;

Console.WriteLine("KATA 001: Stop gninnipS My sdroW\n");

Console.Write("Give me some sentence: ");
string usersSentence = Console.ReadLine();

string convertedSentence = Kata.SpinWords(usersSentence);
Console.WriteLine("\nThis is your sentence after conversion:\n");
Console.WriteLine($"{ convertedSentence }\n");

Console.Write("Press any key...");
Console.ReadKey();
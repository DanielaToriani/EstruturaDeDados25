// See https://aka.ms/new-console-template for more information
using Bubble_Sort;

Console.WriteLine("Ordenação com BubbleSort");
String[] arrStr = new String[] { "Fran", "Renato", "Jani", "Maria" };

foreach (var number in arrStr)
    Console.WriteLine($"[{number}]");
var arrOrderred = BubbleSortOrder.Sort<String>(arrStr);
Console.WriteLine("");
Console.WriteLine("*************");
Console.WriteLine("Vetor Ordenado em Decrescente:");
Console.WriteLine("");
foreach (var number in arrOrderred)
    Console.WriteLine($"[{number}]");
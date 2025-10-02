using System.Collections.Generic;
Console.WriteLine("Invertendo palavras com pilhas (Stacks)");

Console.WriteLine("Digite uma palavra:");
string palavra = Console.ReadLine();

Stack<char> chars = new Stack<char>();
foreach (var c in palavra) chars.Push(c);
string palavra_invetida = string.Empty;

while (chars.Count > 0)
{
    char c = chars.Pop();
    palavra_invetida += c;
}
if (palavra == palavra_invetida)
    Console.WriteLine("É um Palindromo");
else
    Console.WriteLine("Ihhhh moiô");

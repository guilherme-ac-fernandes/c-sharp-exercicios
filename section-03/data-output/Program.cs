// See https://aka.ms/new-console-template for more information

using System.Globalization;

double number = 10.35784;
int age = 32;
string name = "Maria";
string genre = "feminino";

Console.Write("Olá mundo!"); // Não inclui quebra de linha
Console.WriteLine("Bom dia!"); // Inclui quebra de linha
Console.WriteLine("Até mais.");

Console.WriteLine("--- Format Number with ToString ---");
Console.WriteLine(number);
Console.WriteLine(number.ToString("F2"));
Console.WriteLine(number.ToString("F4"));
Console.WriteLine(number.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("--- Placeholders, Concatenation and Interpolation ---");
Console.WriteLine("RESULTADO = {0:F2}", number); // PlaceHolders
Console.WriteLine("RESULTADO = " + number.ToString("F2")); // Concatenação
Console.WriteLine($"RESULTADO = {number:F2}"); // Interpolação
Console.WriteLine("A paciente " + name + " tem " + age + " anos e seu sexo é " + genre);

Console.ReadLine();

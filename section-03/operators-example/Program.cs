// See https://aka.ms/new-console-template for more information


Console.WriteLine("--- Assignment Operators ---");
int number = 10;
Console.WriteLine(number);

number += 2;
Console.WriteLine(number);

number *= 3;
Console.WriteLine(number);

string alphabet = "ABC";
Console.WriteLine(alphabet);

alphabet += "DEF";
Console.WriteLine(alphabet);

int newNumber = 2;
--newNumber;
Console.WriteLine(newNumber);

++newNumber;
Console.WriteLine(newNumber);

Console.WriteLine("--- Implicit Conversion and Casting ---");

float number1 = 34.56f;
double number2 = number1; // Conversão implícita
Console.WriteLine(number2);

double number3 = 34.56;
float number4 = (float)number3;
int number5 = (int)number3;
Console.WriteLine(number4);
Console.WriteLine(number5);



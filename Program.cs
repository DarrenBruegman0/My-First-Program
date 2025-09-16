// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
//firstname lastname definitions
Console.WriteLine("what is your first name?");
string first = Console.ReadLine();

Console.WriteLine("what is your first name?");
string last = Console.ReadLine();

//displays both names

Console.WriteLine($"hello {first} {last}!");

//Numbers io

Console.WriteLine("Enter a Number");
string x1 = Console.ReadLine();
Console.WriteLine("Enter a Number");
string y1 = Console.ReadLine();
Console.WriteLine("Enter a Number");
string z1 = Console.ReadLine();

//String to int32

int x = Convert.ToInt32(x1);
int y = Convert.ToInt32(y1);
int z = Convert.ToInt32(z1);
float a = x + y + z;
Console.WriteLine(a);

Console.WriteLine(x - y);
float b = x * z;
Console.WriteLine(a / y);

Console.WriteLine(x % b);

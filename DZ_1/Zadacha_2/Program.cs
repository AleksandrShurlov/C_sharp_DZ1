﻿int a, b;

Console.Write("Enter number one: ");
a = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32 - преобразует в int значение любого типа

Console.Write("Enter number two: ");
b = Convert.ToInt32(Console.ReadLine()); 
int max = a;
int min = b;

if (b > max) max = b;
if (a < min) min = a;

Console.Write("Max = ");
Console.WriteLine(max);

Console.Write("Min = ");
Console.WriteLine(min);

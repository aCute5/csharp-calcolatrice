// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using csharp_calcolatrice;

Console.WriteLine("Hello, World!");

int num1 = 2;
int num2 = 5;
int num3 = -5; 

Console.WriteLine(HelperCalc.Min(num1, num2));
Console.WriteLine(HelperCalc.Max(num1, num2));
Console.WriteLine(HelperCalc.Add(num1, num2));
Console.WriteLine(HelperCalc.Sottr(num1, num2));
Console.WriteLine(HelperCalc.Absolute(num1));
Console.WriteLine(HelperCalc.Power(num1, num2));
Console.WriteLine(HelperCalc.NOLoopPower(num1, num2));
Console.WriteLine(HelperCalc.NOLoopPower(num1, num3));




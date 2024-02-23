/*
Напишите программу, которая принимает на вход целое число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
Console.Clear();
int numMain = new Random().Next(10, 100);
System.Console.WriteLine(numMain);
int num1 = numMain / 10;
int num2 = numMain % 10;

if (num1 > num2) System.Console.WriteLine($"{num1} Больше!");

if (num1 == num2) System.Console.WriteLine("числа равны!");

if (num1 < num2) System.Console.WriteLine($"{num2} Больше!");

/////////////////////////////////////////////////////////////

string numm1 = numMain.ToString();

if (numm1[0] > numm1[1]) System.Console.WriteLine($"{numm1[0]} String");

if (numm1[0] < numm1[1]) System.Console.WriteLine($"{numm1[1]} String");

if (numm1[0] == numm1[1]) System.Console.WriteLine("Равны String");
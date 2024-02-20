/*
Напишите програму которая на вход принимает 3х значное число, 
2ую цифру этого числа возводит в степень равную 3ей цифре этого числа
*/

Console.Clear();
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int secondNumber = number /10 %10;
System.Console.WriteLine(secondNumber);

int trioNumber = number % 10;
System.Console.WriteLine(trioNumber);

double resalt = Math.Pow(secondNumber,trioNumber);
System.Console.WriteLine(resalt);
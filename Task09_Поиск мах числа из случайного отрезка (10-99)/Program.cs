/*
Напишите программу которая выдает случайное число 
(10-99) и выводит наибольшую цифру из этого числа
89 -> 9
51 -> 5
*/

Console.Clear();
int number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int firstNumber = number / 10;
int secondNumber = number % 10;
if (firstNumber > secondNumber)
{
    Console.WriteLine("Мах цифра " +firstNumber);
}
if (secondNumber > firstNumber)
{
    Console.WriteLine("Мах цифра " + secondNumber);
}
if (firstNumber==secondNumber)
{
    System.Console.WriteLine("Числа равны");
}
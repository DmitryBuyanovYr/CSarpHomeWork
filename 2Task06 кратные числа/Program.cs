/*
Напишите программу которая принимает 2 числа
и оопределяет является ли они кратные друг другу
*/

Console.Clear();
System.Console.Write("Введи первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введи второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
{
    System.Console.WriteLine($"Числа {firstNumber} и {secondNumber} являються кратными");
}
else 
{
    System.Console.WriteLine($"Числа {firstNumber} и {secondNumber} не являються кратными");
}
/*
Написать программу которая генерирует случайное 3х значное число, и удаляет 2 цифру из этого числа
*/
Console.Clear();
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int first = number / 100;
int second = number / 10 % 10; // Для себя :)
int last = number % 10;
int result = first * 10 + last; // слияние 2 цифр в одно число
System.Console.WriteLine(result); 
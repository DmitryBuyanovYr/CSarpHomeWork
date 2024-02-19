/* Напишите програму, которая на вход 
принимает 2 целых числа и проверяет являеться 
ли первое число квадратом второго*/

Console.Clear();
System.Console.Write("Введи превое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(secondNumber,2) == firstNumber)
{
    System.Console.WriteLine($"число {firstNumber} являеться квадратом числа {secondNumber}");
}
else if (Math.Pow(secondNumber,2) != firstNumber)
{
    System.Console.WriteLine($"число {firstNumber} не являеться квадратом числа {secondNumber}");
}






if (number1 == Math.Pow(number2,2))
{
Console.WriteLine("Квадрат числа {1} равен {0}", number1, number2); // новая фишка
}
else Console.WriteLine($"Квадрат числа {number2} НЕ равен {number1}");

// Console.WriteLine("Квадрат числа " + number2 + " равен " + number1); // закоментить все ( Ctrl + /(У правого шифта))

// Alt shift вниз дублировать 
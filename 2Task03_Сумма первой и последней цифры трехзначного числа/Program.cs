/*напишите програму принимающую на вход 3х значное число
и находит сумму первого и последней цифры*/

Console.Clear();
System.Console.Write("Напишите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstNumber = 0;
int secondNumber = 0;
int sum = 0;
if (number <100 || number > 999)
{
    System.Console.WriteLine("Читай условие! ");
}
else
{
firstNumber = number % 10;
System.Console.WriteLine(firstNumber);

secondNumber = number / 100;
System.Console.WriteLine(secondNumber);

sum = firstNumber + secondNumber;
System.Console.WriteLine(sum);
}

// Console.Clear();
// System.Console.Write("Напишите 3-х значное число: ");
// string number = (Console.ReadLine());
// if (number.Length == 3)
// {
//     System.Console.WriteLine(Convert.ToInt32(Convert.ToString(number[0])) + 
//       Convert.ToInt32(Convert.ToString(number[2]))) ;

// }
// else
// {
//     System.Console.WriteLine("ошибка");
// }
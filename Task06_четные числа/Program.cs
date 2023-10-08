/*
Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).


number = 4 -> Число 4 чётное

number = 3 -> Число 3 нечётное

number = 7 -> Число 7 нечётное
*/
System.Console.Write("Введи число: ");
int Nambr = Convert.ToInt32(Console.ReadLine());
if ((Nambr % 2) == 0)
{
    Console.Write($"Число {Nambr} четное");
}
else
{
    Console.Write($"Число {Nambr} не четное");
}
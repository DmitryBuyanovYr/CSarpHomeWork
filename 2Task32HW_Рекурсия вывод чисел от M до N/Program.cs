/*Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

void SearchNumber(int m, int n)
{
    if (n > m)
    {
        if (n <= m)
        {
            return;
        }
        SearchNumber(m, n - 1);
        System.Console.Write($"{n} ");
        
    }
    // else if (n < m)  // Проверку сделал до того как узнал что ее делать не надо
    // {
    //     if (n >= m)
    //     {
    //         return;
    //     }
    //     SearchNumber(m, n + 1);
    //     System.Console.Write($"{n} ");
        
    // }
    //else if  (n == m) System.Console.Write("Числа равны! ");
}

System.Console.Write("Введи число M: ");
int m_Num = Convert.ToInt32(Console.ReadLine())-1!; // -1 для вывода первого числа в консоли
System.Console.Write("Введи число N: ");
int n_Num = Convert.ToInt32(Console.ReadLine())!;
SearchNumber(m_Num, n_Num);

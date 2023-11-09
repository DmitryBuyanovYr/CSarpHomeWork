/*
Не используя рекурсию вывдите превые N числа фибоначи
Если N = 5 -> 0 1 1 2 3
если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void Fibo(int numb)
{
    int[] fibonachi = new int[numb + 1];

    if (numb == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            fibonachi[i] = i;
            System.Console.Write(fibonachi[i] + " ");
        }
        for (int i = 2; i < numb; i++)
        {
            fibonachi[i] = fibonachi[i-2] + fibonachi[i-1];
            System.Console.Write(fibonachi[i] + " ");
        }
    }
}
Fibo(0);
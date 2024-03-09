/*напишите программу которая будет находить сумму цифр в числе*/

int SumNumintr(int num)
{
    if (num == 0) return 0;
    int res = num % 10 + SumNumintr(num / 10);
    return res;
}



System.Console.Write("Веведи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write(SumNumintr(userNumber));
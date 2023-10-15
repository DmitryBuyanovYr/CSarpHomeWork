System.Console.Write("Введи пятизначное число: ");
int userNambr = Convert.ToInt32(Console.ReadLine());

int nambr1 = userNambr % 10;
int nambr2 = userNambr / 10 % 10;
int nambr3 = userNambr / 100 % 10;
int nambr4 = userNambr / 1000 % 10;
int nambr5 = userNambr / 10000 % 10;

int pcNambr = (nambr1 * 10000) + (nambr2 * 1000) + (nambr3 * 100) + (nambr4 * 10) + nambr5;

while (userNambr<10000 || userNambr>100000)
{
    System.Console.WriteLine("Читай условие!");
    break;
}

if (userNambr == pcNambr)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}
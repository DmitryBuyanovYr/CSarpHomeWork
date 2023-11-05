/*
Напишите программу которая преобразуеть 10тичное число в двоичное
*/
System.Console.WriteLine("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
DacVin(number);

/*int DacBin(int arg)
{
    int resalt = 0;
    int temp = 1;
    while (arg > 0)
    {
        resalt += arg % 2 * temp;
        arg /= 2;
        temp *= 10;
    }
    return resalt;
}*/

void DacVin(int numb)
{
    string result = "";
    int binary = 0;
    for (int i = numb; i > 0; i /= 2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.WriteLine(result);
}
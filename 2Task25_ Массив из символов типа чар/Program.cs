/*Задайте массив символов (тип char []). Создайте строку из символов этого массива.*/

Console.Clear();
string ar = Console.ReadLine()!;
char[] arrey = new char[ar.Length];

for (int i = 0; i < arrey.Length; i++)
{
    arrey[i] = ar[i];
    System.Console.Write(arrey[i]);
}

/*string imput = Console.ReadLine();

char [] Mass_char = new char [imput.Length];

for (int i = 0; i < imput.Length; i++)
{
Mass_char[i] = imput[i];
}

void PrintChar(char[] Mass_char)
{
foreach (char i in Mass_char)
{
Console.WriteLine(i);
}
}
PrintChar(Mass_char);*/





/*string CharOfString(char[] arr)
{
string st = "";
foreach (char i in arr)
{
st += i;
}
return st;
}


char[] chars = new char[] {'a', 'b', 'c', 'd'};
Console.WriteLine(CharOfString(chars));*/



/*char[] chers = new char[]{'a','d','c'};
for (int i = 0; i < chers.Length; i++)
{
    System.Console.Write(chers[i]);
    //Console.WriteLine($"Конечный массив: [{char.Join(", ", (chers))}]");
}*/
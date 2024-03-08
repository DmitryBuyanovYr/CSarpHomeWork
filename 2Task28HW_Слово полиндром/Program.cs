/*Задайте произвольную строку. Выясните, является ли она палиндромом.*/

System.Console.Write("Введите слово: ");
string one = Console.ReadLine()!;
//string[] arrayOne = new string[one.Length];
//string[] arrayTwo = new string[arrayOne.Length];


string Reverse(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }


string two = Reverse(one);
Convert.ToChar(one);
Convert.ToChar(two);

if (one == two) System.Console.WriteLine("это слово палиндром");
else System.Console.WriteLine("это слово палиндром");




/*string two = "";
for (int i = one.Length; i > 0; i--)
{
    two = two + one[i];
    System.Console.WriteLine(two);
}*/




/*for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = Convert.ToString(one[i]);
    arrayTwo[i] = Convert.ToString(one[i]);
}
Array.Reverse(arrayTwo);

for (int i = 0; i < arrayTwo.Length; i++)
{
    two[i] = arrayTwo[i];
}
System.Console.WriteLine(two);*/







/*System.Console.WriteLine();
System.Console.Write(one);
string two = one;
for (int i = one.Length; i > 0; i--)
{
    int j = 0;
    two[j] = one[i];
    j++;
}
System.Console.WriteLine(two);*/
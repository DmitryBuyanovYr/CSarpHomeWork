/*Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки*/

void ChoiceConsonants(string a)
{
    if (a.Length==0)
    {
        return;
    }
    string vowels = "aoeiuyAOEIUY";
    if (!vowels.Contains(a[0])) // ((.Contains)проверка на совподение. ! <- знак не равенства)
    {
        
        System.Console.Write($"{a[0]} ");
    }
    ChoiceConsonants(a[1..]); //[1..](возьми всю строку с первого элемента до последнего)
    //ChoiceConsonants(a);

}

string userString = Console.ReadLine()!;
ChoiceConsonants(userString);

////////////////////////////////////////// 2ой вариант решения


void WriteConsonants (string n, int i = 0)
{
if (n.Length == 0)
{
return;
}
string vowels = "euioaEUIOA";
if (!vowels.Contains(n[i]))
{
Console.Write(n[i]);
}
WriteConsonants(n.Substring(i+1,n.Length-1)); //.Substring -> создание новой строки со значением
}

string n = Console.ReadLine()!;
WriteConsonants(n);
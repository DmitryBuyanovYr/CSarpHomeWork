/*Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
Выяснить, сколько среди введённых букв гласных (aouei).*/

System.Console.WriteLine("введи фразу");
string alphabetical = "aoeiuy";
string UserStr = Console.ReadLine()!;
int count = 0;
for (int i = 0; i < UserStr.Length; i++)
{

    for (int j = 0; j < alphabetical.Length; j++)
    {
        if (UserStr[i]==alphabetical[j])
        {
            count++;
        }
    }
}
System.Console.Write($"{UserStr} -> {count} гласных");




/*int CountVowels (string st)
{
int s = 0;
for (int i = 0; i < st.Length; i++)
{
if (st[i] == 'a' || st[i] == 'e' || st[i] == 'u' || st[i] == 'i' || st[i] == 'o'
|| st[i] == 'A' || st[i] == 'E' || st[i] == 'U' || st[i] == 'I' || st[i] == 'O')
{
s++;
}
}
return s;
}

bool CheckIfLetter (string st)
{
for (int i = 0; i < st.Length; i++)
{
if (char.IsLetter(st[i]) || st[i] == ' ')
{
}
else
{
return false;
}

}
return true;
}

string st = Console.ReadLine()!;
if (CheckIfLetter(st))
{
int vowels = CountVowels(st);
Console.WriteLine(vowels);
}
else
{
Console.WriteLine("Введен неверный формат");
}*/



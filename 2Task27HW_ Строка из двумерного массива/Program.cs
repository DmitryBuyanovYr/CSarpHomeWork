/*Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/


char[,] array = new char[2,3];
string art ="";
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        /*int rannd = 0;
        rannd = new Random().Next(0, 9);
        array[i,j] = Convert.ToChar(rannd);*/
        array[i,j] = Convert.ToChar(Convert.ToString(new Random().Next(0, 9)));
        art += array[i,j];
    }
}
 System.Console.Write(art);



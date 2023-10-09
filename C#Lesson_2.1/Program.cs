/*
Поиск мах числа из 9 чисел
*/
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = {9,7,8,2,4,5,6,1,3};
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);


/*int a1 = 53;
int b1 = 45;
int c1 = 775;

int a2 = 65;
int b2 = 9962;
int c2 = 61;

int a3 = 82;
int b3 = 624;
int c3 = 44;*/

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3); // Изменил все цифры сразу, как?

int max = Max(max1, max2, max3);*/

//int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // имба
/*int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)); // таже самое*/

Console.Write(max);
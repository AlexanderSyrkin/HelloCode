// Определить макисмальное число из 9-ти чисел (стихийный метод)

//int a1 = 10;
//int b1 = 12;
//int c1 = 43;
//int a2 = 14;
//int b2 = 16;
//int c2 = 16;
//int a3 = 47;
//int b3 = 18;
//int c3 = 19;

//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

//Console.WriteLine(max);

// Определить максимальное число из 9-ти чисел с помощью "функций".

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 10;
int b1 = 1652;
int c1 = 43;
int a2 = 14;
int b2 = 165666;
int c2 = 16;
int a3 = 4897;
int b3 = 18;
int c3 = 1999999;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max =Max(max1, max2, max3);
int max =Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
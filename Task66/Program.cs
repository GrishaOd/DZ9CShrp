/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int FindSumMtoN(int m, int n)
{
    if (m > n)
    return 0;
    else
    return m + FindSumMtoN(m + 1, n);
}

int FindSumNtoM(int m, int n)
{
    if (m < n)
    return 0;
    else
    return n + FindSumNtoM(m, n + 1);
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

if (m < n)
    {
    int sumMtoN = FindSumMtoN(m, n);
    Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sumMtoN}.");
    }
else if (n < m)
    {
    int sumNtoM = FindSumNtoM(m, n);
    Console.WriteLine($"Сумма натуральных чисел от {n} до {m} равна {sumNtoM}.");
    }

/* 
Если по по условию задачи надо найти сумму чисел в промежутке ИМЕННО от M до N, 
то вариант решения будет такой:

int FindSumMtoN(int m, int n)
{
    if (m > n)
    return 0;
    else
    return m + FindSumMtoN(m + 1, n);
}

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int sumMtoN = FindSumMtoN(m, n);
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sumMtoN}."); 
*/
void Zadacha64()
{
    //     Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
    // в промежутке от N до 1. Выполнить с помощью рекурсии.
    Console.WriteLine("Введите число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Numbers(num);
}
void Numbers(int num, int i = 1)
{
    Console.Write(num + "  ");
    num--;
    if (num < i)
    {
        return;
    }
    Numbers(num, i);
}
void Zadacha66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
    // натуральных элементов в промежутке от M до N.

    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30
    Console.WriteLine("Введите число M: ");
    int num_m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int num_n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сумма элементов от M до N " + SumNumbers(num_m, num_n));
}
int SumNumbers(int num_m, int num_n, int sum = 0)
{
    sum = sum + num_m;
    num_m += 1;
    if (num_m > num_n)
    {
        return sum;
    }
    return SumNumbers(num_m, num_n, sum);
}
void Zadacha68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
    // Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

    Console.WriteLine("Введите число M: ");
    int num_m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int num_n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(AckermanFunc(num_m, num_n));
}
int AckermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermanFunc(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
    return AckermanFunc(m,n);
}
Zadacha64();
Zadacha66();
Zadacha68();
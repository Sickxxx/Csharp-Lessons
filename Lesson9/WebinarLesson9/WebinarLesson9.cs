void Zadacha63()
{
    //     Задача 63: Задайте значение N. Напишите программу, которая выведет
    // все натуральные числа в промежутке от 1 до N.
    Console.WriteLine("Введите число N: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Numbers(num);
}
void Numbers(int num, int i = 1)
{
    Console.Write(i + "  ");
    i++;
    if (i > num)
    {
        return;
    }
    Numbers(num, i);
}
void Zadacha65()
{
    //     Задача 65: Задайте значения M и N. Напишите программу, которая
    // выведет все натуральные числа в промежутке от M до N.
    Console.WriteLine("Введите число M: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Numbers(num, num2);
}
void Zadacha67()
{
    //     Задача 67: Напишите программу, которая будет принимать на вход число и
    // возвращать сумму его цифр.
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumNumbers(num));

}
int SumNumbers(int num, int sum = 0)
{
    sum = sum + num % 10;
    num = num / 10;
    if (num == 0)
    {
        return sum;
    }
    return SumNumbers(num, sum);
}
void Zadacha69()
{
    //     Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
    // возводит число А в целую степень B с помощью рекурсии.
    Console.WriteLine("Введите число A: ");
    int num_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int num_b = Convert.ToInt32(Console.ReadLine());
    Power(num_a, num_b);

}
void Power(int num_a, int num_b, int i = 0, int result = 1)
{
    if (i >= num_b)
    {
        Console.WriteLine($"{num_a}^{num_b} = {result}");
        return;
    }
    result *= num_a;
    i++;
    Power(num_a, num_b, i, result);


}

Zadacha69();
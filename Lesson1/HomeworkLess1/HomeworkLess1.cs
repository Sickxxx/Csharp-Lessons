void Zadacha2()
{// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine("Максимальное число " + max);
}
void Zadacha4()
{
//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");
}
void Zadacha6()
{
    //Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= num)
{
    Console.Write(i + " ");
    i += 2;
}
}
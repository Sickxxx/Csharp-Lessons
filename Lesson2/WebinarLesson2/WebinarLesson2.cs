void Zadacha9()
{
    // 9. Напишите программу, которая выводит
    // случайное число из отрезка [10, 99] и показывает
    // наибольшую цифру числа.
    Random random = new Random();
    int number = random.Next(10, 100);
    Console.WriteLine("Случайное число " + number);
    if (number % 10 > number / 10)
    {
        Console.WriteLine($"Наибольшая цифра в числе: {number % 10}");
    }
    else Console.WriteLine($"Наибольшая цифра в числе: {number / 10}");
}
void Zadacha11()
{
    //  11. Напишите программу, которая выводит случайное
    // трёхзначное число и удаляет вторую цифру этого
    // числа.
    Random random = new Random();
    int number = random.Next(100, 1000);
    Console.WriteLine("Случайное число " + number);
    int number1 = number / 100 * 10 + number % 10;
    Console.WriteLine(number1);
}
void Zadacha12()
{
    //     12. Напишите программу, которая будет принимать
    // на вход два числа и выводить, является ли второе
    // число кратным первому. Если число 2 не кратно числу
    // 1, то программа выводит остаток от деления.
    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 % num2 == 0) Console.WriteLine($"Число {num1} кратно {num2}");
    else Console.WriteLine($"Число {num1} не кратно {num2}, остаток {num1 % num2}");
}
void Zadacha14()
{
    //     14. Напишите программу, которая принимает на
    // вход число и проверяет, кратно ли оно
    // одновременно 7 и 23.
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Число {num} кратно ");
    else Console.WriteLine($"Число {num} не кратно");
}
void Zadacha16()
{
    //     16. Напишите программу, которая принимает на
    // вход два числа и проверяет, является ли одно
    // число квадратом другого.
    Console.WriteLine("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        Console.WriteLine("ДА");
    }
    else Console.WriteLine("НЕТ");
}
Zadacha16();
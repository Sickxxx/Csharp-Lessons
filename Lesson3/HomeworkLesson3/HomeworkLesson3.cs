int InputNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}
void Task1()
{
    //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    //является ли оно палиндромом..
    int num = InputNumber();
    while (99999 < num || num < 9999)
    {
        Console.WriteLine("Число не пятизначное, введите пятизначное число");
        num = InputNumber();
    }
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");


}

void Task2()
{
    //Задача 21 Напишите программу, которая принимает на вход
    //координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Введите координаты точки A:");
    Console.Write("x1: ");
    int x1 = InputNumber();
    Console.Write("y1: ");
    int y1 = InputNumber();
    Console.Write("z1: ");
    int z1 = InputNumber();
    Console.WriteLine("Введите координаты точки B:");
    Console.Write("x2: ");
    int x2 = InputNumber();
    Console.Write("y2: ");
    int y2 = InputNumber();
    Console.Write("z2: ");
    int z2 = InputNumber();
    Console.WriteLine($"Точки:A({x1},{y1},{z1}), B({x2},{y2},{z2})");
    Console.WriteLine($"Расстояние между точками A и B: {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2))}");

}

void Task3()
{
    //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
    int num = InputNumber();
    int k = 1;
    double qube;
    Console.WriteLine("Таблица квадратов для числа " + num);
    if (num > 0)
    {
        while (k <= num)
        {
            qube = Math.Pow(k, 3);
            Console.WriteLine($"{k}\t{qube}");
            k++;
        }
    }
    else if (num < 0)
    {
        while (k >= num)
        {
            qube = Math.Pow(k, 3);
            Console.WriteLine($"{k}\t{qube}");
            k--;
        }
    }
    else Console.WriteLine(num);

}

Task1();
Task2();
Task3();
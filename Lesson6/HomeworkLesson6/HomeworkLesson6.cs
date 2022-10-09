void Zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел.
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    Console.WriteLine("Введите числа через пробел");
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    ElemetAboveZero(numbers);
}
void ElemetAboveZero(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += 1;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля: {sum}");
}
void Zadacha43()
{
    // //Задача 43.Напишите программу, которая найдёт точку
    // пересечения двух прямых, заданных уравнениями y = k1 *
    // x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
    // пользователем.
    Console.WriteLine("Введите коэффициент k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент k2");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения прямых :({x}, {y})");
}
Zadacha41();
Zadacha43();
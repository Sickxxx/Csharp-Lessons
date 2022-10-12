void Zadacha1()
{//Задача 1. Рассчитать значение y при заданном x по формуле
 // y =sin^2*x при х>0,
 // в противном случае y = 1-2sin*x^2
    Console.WriteLine("Введите Х: ");
    double x = Convert.ToInt32(Console.ReadLine());
    double y;
    if (x > 0)
    {
        y = Math.Pow(Math.Sin(x), 2);
        Console.WriteLine(y);
    }
    else
    {
        y = 1 - 2 * (Math.Sin(x * x));
        Console.WriteLine(y);
    }
}
void Zadacha2()
{
    //Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.
    int y = InputNumber();
    int x = y;
    int sum = 0;
    while (x != 0)
    {
        sum = sum + x % 10;
        x = x / 10;
        Console.WriteLine(sum);
        Console.WriteLine(x);
    }
    if (sum % 3 == 0)
    {
        Console.WriteLine($"Сумма цифр в числе {y} кратна трем");
    }
    else Console.WriteLine($"Сумма цифр в числе {y} не кратна трем");
}
int InputNumber()
{
    Console.WriteLine("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}
void Zadacha3()
{
    // Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.
    int n = InputNumber();
    int x = n % 10;
    int y = n / 10 % 10;
    int z = n / 100;
    if (x == 4 || y == 4 || x == 7 || y == 7 || z == 4 || z == 7)
    {
        Console.WriteLine("YES");
    }
    else Console.WriteLine("No");
}
void Zadacha4()
{
    // Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
    int size = 10;
    int[] num = new int[size];
    for (int i = 0; i < size; i++)
    {
        num[i] = i + 1;
    }
    MyLib.Array.PrintArray(num);

}
void Zadacha5() // не решил
{// Задачи повышенной сложности:
 // Задача 5. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
 // Определите самый оптимальный маршрут для торгового менеджера,
 // который выезжает из центра координат.
    Console.WriteLine("Введите номер четверти");
    int num = Convert.ToInt32(Console.ReadLine());
    int x = 0;
    int y = 0;
    if (num == 1)
    {
        x = new Random().Next(0, 11);
        y = new Random().Next(0, 11);
    }
    else if (num == 2)
    {
        x = new Random().Next(0, -11);
        y = new Random().Next(0, 11);
    }
    else if (num == 3)
    {
        x = new Random().Next(0, -11);
        y = new Random().Next(0, -11);
    }
    else
    {
        x = new Random().Next(0, 11);
        y = new Random().Next(0, -11);
    }
    Console.WriteLine($"Точки:A({x},{y}), B({x},{y}), C({x},{y})");

    //Console.WriteLine($"Расстояние между точками A и B: {Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2))}");

}
void Zadacha8()
{
    // Задача 8. Дан массив средних температур (массив заполняется случайно) за последние 10 лет. 
    // На ввод подают номер месяца и год началa и конца.
    // Определить самые высокие и низкие температуры для лета, осени, зимы и весны в заданном промежутке. 
    // Если таких температур нет, сообщить, что определить не удалось.
    int years = 10;
    int month = 12;
    int[] temp = new int[years * month];
    MyLib.Array.FillArray(temp, -30, 30);
    Console.WriteLine("Введите номер месяца");
    int nummonth = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите год начала");
    int yearstart = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите год конца");
    int yearend = Convert.ToInt32(Console.ReadLine());
    int[] valtemp = new int[(yearend - yearstart) * 12];
    ValueTemp(valtemp, temp, nummonth, yearstart, yearend);
    MyLib.Array.PrintArray(valtemp);
    int[] summer = new int[(month * (yearend - yearstart)) / 4];
    int[] winter = new int[(month * (yearend - yearstart)) / 4];
    int[] fall = new int[(month * (yearend - yearstart)) / 4];
    int[] spring = new int[(month * (yearend - yearstart)) / 4];
    if (nummonth == 1 || nummonth == 2 || nummonth == 12)
    {
        int i = (nummonth + ((yearstart - 1) * month))
                    winter[i] = temp[i]
    }
}
void ValueTemp(int[] valtemp, int[] temp, int nummonth, int yearstart, int yearend)
{
    int j = 0;
    if (yearstart == 1)
    {
        for (int i = nummonth; i < nummonth + ((yearend - yearstart) * 12); i++)
        {
            valtemp[j] = temp[i];
            j++;
        }
    }
    else if (yearstart > 1)
    {
        for (int i = (nummonth + ((yearstart - 1) * 12)); i < nummonth + ((yearend - yearstart) * 12); i++)
        {
            valtemp[j] = temp[i];
            j++;
        }
    }
}
void Zadacha9()
{
    // Задача 9. На вход подаётся число n > 4, указывающее длину пароля. 
    // Создайте метод, генерирующий пароль заданной длины. 
    //В пароле обязательно использовать цифру, букву и специальный знак.
    int n = new Random().Next(4, 11);
    Console.WriteLine("Длина пароля равна: " + n);
    string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
    string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
    string[] symbols = { "!", "@", "#", "$", "%", "^", "&", "*" };
    string[] password = new string[n];
    for (int i = 0; i < n; i++)
    {
        int k = new Random().Next(1, 4);
        if (k == 1)
        {
            int len = letters.Length - 1;
            int j = new Random().Next(0, len);
            password[i] = letters[j];
        }
        else if (k == 2)
        {
            int len = numbers.Length - 1;
            int j = new Random().Next(0, len);
            password[i] = numbers[j];
        }
        else
        {
            int len = symbols.Length - 1;
            int j = new Random().Next(0, len);
            password[i] = symbols[j];
        }
        Console.Write(password[i]);
    }

}
void Zadacha11()
{
    // Задача 11. Массив из ста элементов заполняется случайными числами от 1 до 100.
    // Удалить из массива все элементы, содержащие цифру 3. 
    // Вывести в консоль новый массив и количество удалённых элементов.
    int size = 20;
    int size2 = size;
    int[] numbers = new int[size];
    MyLib.Array.FillArray(numbers, 1, 100);
    Console.WriteLine("Первый массив");
    MyLib.Array.PrintArray(numbers);
    int deletevalue = 3;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] == deletevalue || numbers[i] % 10 == 3 || numbers[i] / 10 == 3)
        {
            int amp = numbers[i];
            numbers[i] = numbers[size - 1];
            numbers[size - 1] = amp;
            size = size - 1;
            count += 1;
        }
        if (numbers[i] == deletevalue || numbers[i] % 10 == 3 || numbers[i] / 10 == 3)
        {
            int amp = numbers[i];
            numbers[i] = numbers[size - 1];
            numbers[size - 1] = amp;
            size = size - 1;
            count += 1;
        }
    }
    Console.WriteLine("Колличество цифр с 3: " + count);
    int[] numbers2 = new int[size2 - count];
    for (int i = 0; i < size2 - count; i++)
    {
        numbers2[i] = numbers[i];
    }
    Console.WriteLine("второй массив");
    MyLib.Array.PrintArray(numbers2);
}
void Zadacha12()
{
    // Задача 12. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно
    // от 2 до 100.
    int n = new Random().Next(2, 100);
    Console.WriteLine("Случайное число: " + n);
    for (int i = 1; i < n; i++)
    {
        for (int j = 1; j < 10; j++)
        {
            Console.WriteLine($"{i}*{j} = {i * j}");
        }
        Console.WriteLine();
    }
}
void Zadacha13()
{
    // Задача 13. Дана игра со следующими правилами. Первый игрок называет любое натуральное число от 2 до 9,
    // второй умножает его на любое натуральное число от 2 до 9, первый умножает результат на любое натуральное 
    //число от 2 до 9 и т. д. Выигрывает тот, у кого впервые получится число больше 1000. 
    // Запрограммировать консольный вариант игры.
    Console.WriteLine("Введите число N от 2 до 9");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число от 2 до 9 для умножения его на N");
    int n = Convert.ToInt32(Console.ReadLine());
    number = number * n;
    int count = 0;
    while (number < 1000)
    {
        Console.WriteLine("Введите число от 2 до 9 для умножения результата");
        number = number * Convert.ToInt32(Console.ReadLine());
        count += 1;
        Console.WriteLine("Число" + number);

    }
    if (count % 2 == 0)
    {
        Console.WriteLine($"Победил второй игрок, число равняется {number}");
    }
    else Console.WriteLine($"Победил первый игрок, число равняется {number}");

}
Zadacha8();

namespace MyLib
{
    class Array
    {

        public static void FillArray(int[] numbers, int minValue = 0, int maxValue = 100)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
            }
        }
        public static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
        }
        public static void FillArray(double[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round(random.NextDouble() * 200 - 100, 2);
            }
        }
        public static void PrintArray(double[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
        }
        public static void ReverseArray(int[] numbers)
        {
            int maxIndex = numbers.Length - 1;
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
            }
        }
    }
    class ArrayMD
    {
        public static void FillArray(int[,] arr, int minValue = 0, int maxValue = 100)
        {
            Random random = new Random();
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = random.Next(minValue, maxValue);
                }
            }
        }
        public static void PrintArray(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void FillArray(double[,] arr)
        {
            Random random = new Random();
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = Math.Round(random.NextDouble() * 100, 1);
                }
            }
        }
        public static void PrintArray(double[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void AverageColumns(int[,] arr)
        {
            Console.Write("Среднее арифметическое каждого столбца: ");
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int j = 0; j < rows; j++)
            {
                double count = 0;
                double sum = 0;
                for (int i = 0; i < columns; i++)
                {
                    sum = sum + arr[i, j];
                    count += 1;
                }
                double average = Math.Round(sum / count, 2);
                Console.Write(average + ";  ");
            }
        }
        public static void RowsSort(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int temp = 0;
            for (int k = 0; k < rows; k++)
            {
                for (int i = 0; i < columns; i++)
                {
                    for (int j = i + 1; j < columns; j++)
                    {
                        if (arr[k, i] < arr[k, j])
                        {
                            temp = arr[k, i];
                            arr[k, i] = arr[k, j];
                            arr[k, j] = temp;
                        }
                    }
                }
            }
        }
        public static void MatrixMultiplication(int[,] numbers_a, int[,] numbers_b)
        {
            int rows_c = numbers_a.GetLength(0);
            int columns_c = numbers_b.GetLength(1);
            int length_a = numbers_a.GetLength(1);
            int length_b = numbers_b.GetLength(0);
            int[,] numbers_c = new int[rows_c, columns_c];
            int count = 0;
            if (length_a == length_b)
            {
                for (int i = 0; i < rows_c; i++)
                {
                    for (int j = 0; j < columns_c; j++)
                    {
                        count = 0;
                        while (count < length_a)
                        {
                            numbers_c[i, j] += numbers_a[i, count] * numbers_b[count, j];
                            count += 1;
                        }
                    }
                }
                Console.WriteLine("");
                MyLib.ArrayMD.PrintArray(numbers_c);
            }
            else Console.WriteLine($"Умножение матриц невозможно, столбцы {length_a} и строки {length_b} у матрицы не равны");
        }

    }

}
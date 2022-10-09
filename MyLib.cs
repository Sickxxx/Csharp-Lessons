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
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round(random.NextDouble * 200 - 100, 2);
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

    }
}
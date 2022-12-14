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
    }
}
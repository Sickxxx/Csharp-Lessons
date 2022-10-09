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
}
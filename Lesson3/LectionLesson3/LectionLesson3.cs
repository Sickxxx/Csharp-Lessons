void Zadacha1()
{
    string text = "— Я думаю, — сказал князь, улыбаясь, — что, +
                + "ежели бы вас послали вместо нашего милого Винценгероде,"
                + "вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";
    string Replase(string text, char oldValue, char newValue)
    {
        string result = String.Empty;
        int length = text Length;
        for (int i = 0; i < length; i++)
        {
            if (text[i] == oldValue) result = result + $"{NewValue}";
            else result + result $"{text[i]}";
        }
        return result;
    }
    string newText = Replace(text, "", "|");
    Console.WriteLine(newText);
}
void Zadacha2()
{
    int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
    void PtintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($”{ array[i]}”);
        }
    Console.WriteLine();
    }
void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j
            }
        }
        int temporary = array[i]
    array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
}
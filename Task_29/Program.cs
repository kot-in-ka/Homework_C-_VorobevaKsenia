// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Random random = new Random();
int size = 8;
int[] arr = new int[size];
FillArray(arr);
Console.WriteLine("Массив: ");
PrintArray(arr);
for (int i = 0; i < arr.Length; i++)
for (int j = i + 1; j < arr.Length; j++)
if (arr[i] > arr[j])
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(-100, 100);
    }
}
void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}
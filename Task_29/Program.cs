// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

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
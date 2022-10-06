// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели, что бы узнать является ли он выходным ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void ChoiceDay (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7)
  {
        Console.WriteLine("это не день недели");
  }
  else 
  Console.WriteLine("не выходной");
}
ChoiceDay(dayNumber);


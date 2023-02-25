// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
  Console.WriteLine("Во введенном числе 3 цифры нет ");
}
else
{
  if(num > 99 && num < 1000)
  {
    num = num / 10 % 10;
    Console.WriteLine($"Третье число: {num}");
  }
  if(num >= 1000)
  {
    num = num / 100 % 10;
    Console.WriteLine($"Третье число: {num}");
  }
}


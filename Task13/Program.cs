// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое целое число");
string number = Console.ReadLine();
int index = 2;
if (index < number.Length)
{
    Console.WriteLine("Третья цифра числа:" + number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
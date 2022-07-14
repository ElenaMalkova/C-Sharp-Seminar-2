// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели");
int day = int.Parse(Console.ReadLine());
if (day == 6 | day == 7)
{
    Console.WriteLine("Выходной день");
}
else if (day > 0 & day < 6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
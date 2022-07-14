// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите цифру соотвествующую дню недели: ");
int numberOfWeek = int.Parse(Console.ReadLine());

if (numberOfWeek > 0 & numberOfWeek < 6)
{
    Console.Write("NO");
}
if (numberOfWeek > 5 & numberOfWeek < 8)
{
    Console.Write("YES");
}
if (numberOfWeek < 1 || numberOfWeek > 7)
{
    Console.Write("Числу " + numberOfWeek + " не соотвествует ни один из дней недели");
}

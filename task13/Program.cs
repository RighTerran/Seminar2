// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("Число не содержит трех знаков");
}
else
{
    while (n > 1000)
    {
        n = n / 10;
    }
    int findThirdDigit = n % 10;
    Console.WriteLine("Третьей цифрой в числе является " + findThirdDigit);

}

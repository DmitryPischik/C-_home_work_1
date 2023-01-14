// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое целое положительное число: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе целое положительное число: ");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if (number2 * number2 == number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

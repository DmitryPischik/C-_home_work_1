// Показать четные числа от 1 до N

Console.Write("Введите целое число больше 1: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int i = 1;
while (i <= N)
{
    if (i % 2 == 0) 
    {
        Console.WriteLine(i);
    }
    i++;
}

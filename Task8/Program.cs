// Удалить вторую цифру трёхзначного числа

Console.Write("Введите целое трёхзначное число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int n1 = N / 100;
int n2 = N % 10;

Console.WriteLine(n1 * 10 + n2);
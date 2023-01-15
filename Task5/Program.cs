// Показать последнюю цифру трёхзначного числа

Console.Write("Введите целое трёхзначное число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(N % 10);

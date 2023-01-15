// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Задайте целое число: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int random_number = new Random().Next(1, 1000);

if (random_number % N == 0)
{
    Console.WriteLine("Число " + random_number + " кратно " + N);
}
else
{
    int lost = random_number % N;
    Console.WriteLine("Число " + random_number + " некратно " + N + ". Остаток равен: " + lost);
}

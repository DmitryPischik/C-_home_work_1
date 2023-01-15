// Найти третью цифру числа или сообщить, что её нет

int random_number = new Random().Next(1, 1000);
int div = random_number / 10;

if (div < 10)
{
    Console.WriteLine("В числе " + random_number + " нет третьей цифры ");
}
else
{
    Console.WriteLine((random_number - div * 10) + " - третья цифра числа " + random_number);
}

// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10, 100);
Console.WriteLine(n);

int n1 = n / 10;
int n2 = n % 10;
int max = n1;
if (n2 > n1) max = n2;
Console.WriteLine("наибольшая цифра числа: " + max);
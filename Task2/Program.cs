// По заданному номеру дня недели вывести его название

Console.Write("Введите номер дня недели: ");
int day_of_the_week = int.Parse(Console.ReadLine() ?? "0");

if (day_of_the_week == 1) {Console.WriteLine("Понедельни");}
else
if (day_of_the_week == 2) {Console.WriteLine("Вторник");}
else
if (day_of_the_week == 3) {Console.WriteLine("Среда");}
else
if (day_of_the_week == 4) {Console.WriteLine("Четверг");}
else
if (day_of_the_week == 5) {Console.WriteLine("Пятница");}
else
if (day_of_the_week == 6) {Console.WriteLine("Суббота");}
else
if (day_of_the_week == 7) {Console.WriteLine("Воскресенье");}
else {Console.WriteLine("Нет такого дня в недели");}


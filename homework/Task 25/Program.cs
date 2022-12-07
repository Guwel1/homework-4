// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int number = a;
if (b==0)
number=1;
for (int i = 2; i <= b; i ++ )
        number = number*a;
Console.Write($"Число А, возведеннео в степень В: {number}");
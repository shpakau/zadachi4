// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Задача 25");
Console.Write("Возведение числа А в натуральную степень В");

int Numbers(int number_A, int number_B)
{
  int result = 1;
    for ( int i = 1; i <= number_B; i++)
    {
        result = result * number_A;
    }
  return result;
}

Console.WriteLine();
Console.WriteLine("Введите число А: ");
int number_A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int number_B = Convert.ToInt32(Console.ReadLine());
int numbers = Numbers(number_A, number_B);
Console.WriteLine("Ответ: " + numbers);
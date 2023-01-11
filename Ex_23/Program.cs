//Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
double result;
while(i <= N)
{
   result = Math.Pow(i, 3);
   i++;

   Console.WriteLine("Значение числа в кубе равно " + result);
}

//Console.WriteLine("Цикл завершил свою работу");

// Console.WriteLine("Введите число: ");

// double result;
// for (int i = 1; i <= 3; i++)
// {
//     result = Math.Pow(i, 3);
// }
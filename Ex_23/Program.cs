//Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;
double result;
while(i <= N)
{
    result = Math.Pow(N, 3);
    i++;

    Console.WriteLine("Значение числа в кубе равно" + result);
}

Console.WriteLine("Цикл завершил свою работу");
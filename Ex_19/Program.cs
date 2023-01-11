/**Задача 19. Напишите программу, 
которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
**/

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

char [] arr = new char [5];
arr = num.ToString().ToArray();
//Console.WriteLine(arr[0]);

if(arr[0] == arr[4] & arr[1] == arr[3])
{
    Console.Write("Введенное число является палиндромом");
}
else
{
 Console.Write("Введенное число не является палиндромом");   
}



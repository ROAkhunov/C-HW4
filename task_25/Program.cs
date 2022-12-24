//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!
int GetStep(int n,int m){
 int   mult=1;
for (int i = 1; i <= m; i++)
{
   mult*=n;
}
return mult;
}
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write(GetStep(A,B));

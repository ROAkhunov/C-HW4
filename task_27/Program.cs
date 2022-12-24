// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12
int GetSum(int n){
    int sum=0;
   if (n<0)
   {
    n*=(-1);
   }
    while (n>0)
    {
        sum+=n%10;
        n/=10;
    }
    return sum;
}
Console.Write("Ввeдите число: ");
int number=int.Parse(Console.ReadLine()!);
Console.Write(GetSum(number));
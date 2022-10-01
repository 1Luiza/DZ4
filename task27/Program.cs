/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int sumOfDigit(int userNumber)
{
    int sum = 0;
    while (userNumber > 0)
    {
        int currentDigit = userNumber % 10;
        sum = sum + currentDigit;
        userNumber = userNumber / 10;
    } 
    return sum;    
}

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = sumOfDigit(userNumber);
Console.WriteLine(result);

// Семинар 2 от 11.04.2023
// Задание 1 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundredes = num / 100;
//     int units = num % 10;

//     int result = hundredes * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int shortNumber = CutNumber(randNumber);

// Console.WriteLine($"Новая версия {randNumber} и {shortNumber}");

// Задание 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.


// int CutNumber (int numb)
// {
//     int tens = numb / 10;
//     int unit = numb % 10;
//     if (tens > unit) return tens;
//     else return unit;
// }
// int randNumber = new Random().Next (10, 100);
// int max = CutNumber(randNumber);
// Console.WriteLine($"Максимальная цифра числа {randNumber} это {max}");


//вариант второй
/*
int MaxDigits(int ranNumber)
{
    int units = ranNumber % 10;
    int dozents = ranNumber / 10;
    if (units > dozents) return units;
    else return dozents;
}
int random = new Random().Next(10, 100);
int randomNumber = MaxDigits(random);
Console.WriteLine(random);
Console.WriteLine(randomNumber);
*/
// 2- Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

/*
bool even(int num1, int num2)
{
    if(num2 % num1 == 0)
        return true;
    else
        return false; 
}
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
bool result = even(num1, num2);
Console.WriteLine(result);
*/

// 3- Напишите программу, которая принимает на вход число n и проверяет, кратно ли оно одновременно a и b.
/*
bool even(int num1, int num2, int num3)
{
    if(num1 % num3 == 0 && num2 % num3 == 0)
        return true;
    else
        return false; 
}
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = even(num1, num2, num3);
Console.WriteLine(result);
*/

// 4- Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*
bool square(int num1, int num2)
{
    if((num1 * num1 == num2) || (num2 * num2 == num1))
        return true;
    else
        return false;
}
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = square(num1, num2);
Console.WriteLine(result);
*/
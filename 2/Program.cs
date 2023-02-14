// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
// (левая граница, правая граница +1)
// int number = new Random().Next(10, 100);
//int number = new Random().Next(0, 11); // Первый параметр = 0
//int number = new Random().Next(11); // Два параметра работы 9 и 10 строчки одинаковы
// Если в Next() не указан 1 параметр, идем от 0
int number = new Random().Next(10, 100);
int firstValue = number / 10; // Первая цифра нашего числа (78 / 10 = 7)
int secondValue = number % 10; // Вторая цифра: 78 % 10 = 8 остаток(78 - 7*10 = 78 - 70 = 8)
int max = firstValue; // Пусть максимум - первая цифра в моем числе 78 (max = 7)

if (secondValue > max) //  8 > 7, max = 8
{
    max = secondValue;
}

Console.WriteLine("Максимальная цифра в числе: " + number  + " - это " + max);
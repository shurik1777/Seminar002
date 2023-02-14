// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// "%" - взятие остатка, как будто делим в столбик и берем остаток( 5 % 3 = 2, 6 % 2 = 0)
// == - проверка на равенство равна ли левая часть правой
// if (secondNumber == 0)
// {
//     return;
// }
if (firstNumber % secondNumber == 0) // Кратно: остатка нет (равен 0)
{
    Console.WriteLine("Кратно!");
}
else // Проверяем, что остаток не равен 0 => есть остаток => число не кратное
{
    // Console.WriteLine("Не кратно, остаток от деления равен " +  firstNumber % secondNumber);
    Console.WriteLine($"Не кратно, остаток от деления {firstNumber} на {secondNumber} равен: {firstNumber % secondNumber}");
}
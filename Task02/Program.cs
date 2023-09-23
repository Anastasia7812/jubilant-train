// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите целое число 1");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите целое число 2");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine( $" max={numberOne}");
    }
else
{
    Console.WriteLine($"max={numberTwo}");
}
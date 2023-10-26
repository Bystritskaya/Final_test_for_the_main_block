/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Write("Введите элементы массива через запятую: ");
string[] input = Console.ReadLine().Split(',');

string[] output = new string[input.Length];
int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        output[count] = input[i];
        count++;
    }
}

Console.WriteLine("Результат:");
for (int i = 0; i < count; i++)
{
    Console.Write(output[i] + " ");
}
using System;
Console.Write("Ввидете количество чисел в ряду Фибоначчи: ");

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Числа Фибоначчи:");
int[] array = new int[n];
array[0] = 0;
array[1] = 1;
Console.Write($"{array[0]}, {array[1]} ");
for (int i = 2; i < n; i++)
{
    int first = array[i - 1];
    int second=array[i - 2];
    array[i] = first + second;

    Console.Write($", {array[i]} "); 
    first = second;
    second = array[i];
}


﻿// Написать программу, которая из имеющегося массива строк формирует массив строк, длина 
// которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  


string[] MassivStrok = { "fhghg", "xxx", "wthryr", "h" };

for (int i = 0; i < MassivStrok.Length; i++)
{
    if (MassivStrok[i].Length <= 3)
    {
        Console.Write($" {MassivStrok[i]} ");
    }
}

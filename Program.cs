// Знакомство с языками программирования 
// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length) Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
// }

// int PositiveNum(int[] array)
// {

//     int even = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) even++;
//     }
//     return even;
// }

// int[] arr = CreateArrayRndInt(4, 100, 999);
// PrintArray(arr);
// int evenNumb = PositiveNum(arr);
// Console.WriteLine($"-> {evenNumb}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
// }

// int ArrayOddIndexSum(int []array) //нечетные для индексов 1 и 3
// {
//     int arr = array[1] + array[array.Length - 1];
//     int sum=0;
//     for (int i = 2; i < array.Length; i+=2)
//     {
//          if (array[i]>sum) sum=+array[i];
//     }
//     return arr;
// }

// int[] arr = CreateArrayRndInt(4, -9, 99);
// PrintArray(arr);
// int indexSum=ArrayOddIndexSum(arr);
// Console.Write("->");
// Console.WriteLine(indexSum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArrayInt(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}, ");
//     }
//     Console.Write("]");
// }

// int GetMaxNum(int[] array)
// {
//     int maxNum = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         maxNum = Math.Max(maxNum, array[i]);
//     }
//     return maxNum;
// }

// int GetMinNum(int[] array)
// {
//     int minNum = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         minNum = Math.Min(minNum, array[i]);
//     }
//     return minNum;
// }

// int GetDifMinMax(int[] array)
// {
//     int maxNum = GetMaxNum(array);
//     int minNum = GetMinNum(array);
//     int result = (maxNum - minNum);
//     return result;
// }

// int[] array = CreateArrayRndInt(4, 1, 99);
// PrintArrayInt(array);
// int maxNum = GetMaxNum(array);
// int minNum = GetMinNum(array);
// int dif = GetDifMinMax(array);
// Console.WriteLine($"-> {dif}");

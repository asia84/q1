﻿/*36/Задайте одномерный массив,заполненный случайными числами.
Найдите сумму элементов, стоящих на нечетных позициях.
[3,7,23,12]->19
[-4,-6,89,6]-> 0
*/




int[] array = new int[10];//количество в массиве
for (int i = 0; i < 10; i++)
{ 
    array[i] = new Random().Next(-50, 50);//взяли разбег  чисел
}
Console.WriteLine("[" + string.Join(", ", array) + "]");//красиво оформили массив

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
     if (i % 2 == 1)//если позиция делится с остатком на 2,то она нечетная
        {
            sum += array[i];//посчитали сумму
        }
    
}
    

Console.WriteLine("Сумма чисел на нечетных позициях: " + sum);//красиво выводим массив без использования цикла
Console.WriteLine();

﻿using static System.Console; 
      //  Задача 0 
     //  *Задача 2:** Напишите программу, которая на 
    //  вход принимает два числа и выдаёт, 
   //  какое число большее, а какое меньшее.
  //  a = 5; b = 7 -> max = 7
 //  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

Clear();

WriteLine("Введите два числа: ");

int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());
if (a>b)
{
    WriteLine($"max: {a}");
    WriteLine($"min: {b}");
} 
else
{
    WriteLine($"Большее число: {b}");
    WriteLine($"Меньшее число: {a}");
}

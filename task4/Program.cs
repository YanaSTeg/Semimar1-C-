﻿// Напишите программу которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
 while(i <= N) 
 {
   Console.Write (i + " ");
   i++;
 } 
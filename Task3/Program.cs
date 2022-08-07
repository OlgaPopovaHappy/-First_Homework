using static System.Console; 
     //  Задача 3
    //  **Задача 8:** Напишите программу, которая на 
   //  вход принимает число (N), а на выходе 
  //  показывает все чётные числа от 1 до N.
 //  5 -> 2, 4
//  8 -> 2, 4, 6, 8

Clear();
WriteLine("Введите число:");
int N = Convert.ToInt32(ReadLine());
int a = 1;
while (N>=a)
{
    if (a%2==0)
    {
        WriteLine(a);
    }    
    a++;
}

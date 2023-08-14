using System.Diagnostics.CodeAnalysis;

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

    //64.Задайте значения M и N.Напишите рекурсивный метод который выдает
    // все натуральные числа от M до N кратные трем.
void Recursion64(int counter, int number)
{
    if (counter > number) return;
    {
        if (counter % 3==0)
        {
           Console.Write($"{counter} ");
        }
    }
    Recursion64(counter +1, number);
    }
    
    Console.Clear();

    int counter = Input("Введите число M : ");
    int number = Input("Введите число N : ");

    Recursion64(counter,number);

// ЗАДАЧА 66 НЕРЕШЕНА.
    //66.Задайте значения M и N.Напишите рекурсивный метод который
    // выдает сумму натуральных элементов от M до N.
void Recursion66(int counter, int number,int x =0)
{
    if (counter  > number) return;
    x += counter;
    counter++;
    Recursion66(counter,number,x);
}    
   

Console.Clear();

int counter = Input("Введите число M : ");
int number = Input("Введите число N : ");
int x = Recursion66(counter,number,x);
Console.WriteLine($"Сумма  чисел  равна {x}");

Recursion66(counter,number,x);
//void Task68()
//{
    // напишите программу вычисления функции акермана с помощью рекурсии.
    //Даны два не отритцательных числа от m до n .
//}
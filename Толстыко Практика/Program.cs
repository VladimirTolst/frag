using System;
using System.Security.Cryptography.X509Certificates;
// Задавание массива
int[,] mainarray = { { 9, 10, 11, 12 }, { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 13, 14, 15, 16 } };
int x=0, y=0, val=0;
// Вывод начального массива
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", mainarray[i, j]);
    }
    Console.WriteLine();
}
static bool testExit(string test)
{                                  
    if (test == "exit")                     //вместо "exit" любое кодовое слово для выхода
    {
        return true;
    }
    else
    {
        return false;
    }
}
static bool testError(string test, int val)
{
    try
    {
        val = 0;
        val = Convert.ToInt32(test);
        return false;
    }
    catch (Exception ex) { return true; }
}
static void elemcord(int[,] mainarray, int val, out int x, out int y, string test)
{
    x = 0;
    y = 0;
    val = Convert.ToInt32(test);
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if(mainarray[i, j] == val)
            {
                x = i;
                y = j;
            }
        }
    }
}






while (1 != 0)
{

    Console.WriteLine("Введите первое число: ");
    string test = Console.ReadLine();
    if (testError(test, val))
    {
        if (testExit(test))
        {
            return;
        }
        Console.WriteLine("Неправильный ввод");
    }
    else
    {
        elemcord(mainarray, val, out x, out y, test);
        int x1 = x;
        int y1 = y;
        Console.WriteLine("Введите второе число: ");
        test = Console.ReadLine();
        if (testError(test, val))
        {
            if (testExit(test))
            {
                return;
            }
            Console.WriteLine("Неправильный ввод");
        }
        elemcord(mainarray, val, out x, out y, test);
        int x2 = x;
        int y2 = y;





        // Проверка рядом ли числа друг с другом(без диагонали)

        if ((x1 == x2 + 1 || x1 == x2 - 1) ^ (y1 == y2 + 1 || y1 == y2 - 1))
        {
            if (x1 - x2 >= -1 & y1 - y2 >= -1)
            {
                // Смена чисел
                int temp = mainarray[x1, y1];
                mainarray[x1, y1] = mainarray[x2, y2];
                mainarray[x2, y2] = temp;

                Console.Clear();
                // Вывод изменённого массива
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("{0}\t", mainarray[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Данные числа не рядом");
            }
        }
        else
        {
            Console.WriteLine("Данные числа не рядом");
        }
    }
}


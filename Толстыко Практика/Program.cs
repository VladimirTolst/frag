using System;
// Задавание массива
int[,] mainarray = { { 9, 10, 11, 12 }, { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 13, 14, 15, 16 } };
// Вывод начального массива
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", mainarray[i, j]);
    }
    Console.WriteLine();
}
try
{
    while (1!=0) {
        // Первые корды для смены
        Console.WriteLine("Введите координаты первого числа(строка, столбец): ");
        string test = Console.ReadLine();
        if (test == "exit")
        {
            return;
        }
        string[] tokens = test.Split();
        int x1 = int.Parse(tokens[0]);
        int y1 = int.Parse(tokens[1]);
        Array.Clear(tokens);

        // Вторые корды для смены
        Console.WriteLine("Введите координаты второго числа(строка, столбец): ");
        test = Console.ReadLine();
        if (test == "exit")
        {
            return;
        }
        tokens = test.Split();
        int x2 = int.Parse(tokens[0]);
        int y2 = int.Parse(tokens[1]);
        Array.Clear(tokens);

        Console.Clear();
        // Проверка рядом ли числа друг с другом(без диагонали)
        if (x1 == x2 + 1 ^ x1+1 == x2 ^ y1 == y2 + 1 ^ y1 + 1 == y2)
        {
            // Смена чисел
            int temp = mainarray[x1, y1];
            mainarray[x1, y1] = mainarray[x2, y2];
            mainarray[x2, y2] = temp;
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
    } }
catch (Exception)
{
    Console.WriteLine("Неверный ввод");
}
/*EventArgs esc = new EventArgs();
Console.WriteLine(esc);
*///while (esc != true){}


//EventArgs esc = new EventArgs();
/*for (int i = 0; i < mainarray.Length - 1; i += 2)
{
    int temp = mainarray[i, j];
    mainarray[i, j] = mainarray[i + 1, j];
    mainarray[i + 1 , j] = temp;
}*/
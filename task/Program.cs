Console.Write("Введите номер задачи (64, 66, 68): ");
int taskNumber = Convert.ToInt32(Console.ReadLine());
switch (taskNumber)
{
    case 64:
        TaskNumber64();
        break;

    case 66:
        TaskNumber66();
        break;

    case 68:
        TaskNumber68();
        break;

    default:
        Console.WriteLine("Вы ввели неверный номер");
        break;
}


void TaskNumber64()
{
    Console.Write("Введите число: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int end = 1;
    if (start<=0) Console.WriteLine("Неверный ввод (число должно быть положительным и не равнятся нулю)");

    else
    {
        string Recursion(int start, int end)
        {
            if (start==end)
            {
                return start.ToString();
            }
            return (start + ", " + Recursion((start-1), end));
        }

        Console.WriteLine($"Результат: {Recursion(start, end)}");
    }
}


void TaskNumber66()
{
    Console.Write("Введите число 1-е число: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число последнее число: ");
    int end = Convert.ToInt32(Console.ReadLine());;
    Console.WriteLine();
    
    if (end<start) Console.WriteLine("Вы ввели неверные числа (последнее число должно быть больше первого)");
    else
    {
        Console.Write($"Сумма чисел от {start} до {end} равна: "); 
        int Recursion(int start, int end)
        {
            if (start==end)
            {
                return start;
            }
            return (start + Recursion((start+1), end));
        }
    
        Console.WriteLine(Recursion(start, end));
    }
}


void TaskNumber68()
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    int Recursion(int m, int n)
    {
        if (m==0)
        {
            return n+1;
        }
        else if (n==0)
        {
            return Recursion(m-1, 1);
        }
        else 
        {
            return Recursion(m-1, Recursion(m, n-1));
        }
    }

    Console.WriteLine($"Результат: {Recursion(m, n)}");
}
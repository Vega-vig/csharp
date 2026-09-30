using System;
public class Tasks
{
    public int SumLastNums(int x)
    {
        if (x < 0) x = -x;
        int e = x % 10;   
        int w = (x % 100) / 10; 
        return e + w;
    }
       
    
    public bool IsPositive(int x)
    {
        return (x > 0) ? true : false;
    }
        
    
    public bool IsUpperCase(char x)
    {
        return (x >= 'A' && x <= 'Z') ? true : false;
    }
        
    
    public bool IsDivisor(int a, int b) 
    {
        if (a == 0 || b == 0) return false;
        return (a % b == 0 || b % a == 0) ? true : false;
    }

    
    public int LastNumSum(int a, int b)
    {
        if (a < 0) a = -a;
        if (b < 0) b = -b;
        return (a % 10) + (b % 10);
    }


    public double SafeDiv(int x, int y)
    {

        if (y == 0) return 0;
        return (double)x / y;
    }
    
    
    public string MakeDecision(int x, int y)
    {
        string sign;
        if (x > y)
        {
            sign = ">";
        }
        else if (x < y)
        {
            sign = "<";
        }
        else
        {
            sign = "==";
        }
        return x + " " + sign + " " + y;
    }


    public bool Sum3(int x, int y, int z)
    {
        return (x + y == z || x + z == y || y + z == x) ? true : false;
    }

    
    public string Age(int x)
    {
        int lastTwo = x % 100;
        int lastOne = x % 10;
        string word;

        if (lastTwo >= 11 && lastTwo <= 14)
        {
            word = "лет";
        }
        else if (lastOne == 1)
        {
            word = "год";
        }
        else if (lastOne == 2 || lastOne == 3 || lastOne == 4)
        {
            word = "года";
        }
        else
        {
            word = "лет";
        }
        return x + " " + word;
    }


    public void PrintDays(string x)
    {
        switch (x)
        {
            case "понедельник": Console.WriteLine("понедельник"); goto case "вторник";
            case "вторник":     Console.WriteLine("вторник");     goto case "среда";
            case "среда":       Console.WriteLine("среда");       goto case "четверг";
            case "четверг":     Console.WriteLine("четверг");     goto case "пятница";
            case "пятница":     Console.WriteLine("пятница");     goto case "суббота";
            case "суббота":     Console.WriteLine("суббота");     goto case "воскресенье";
            case "воскресенье": Console.WriteLine("воскресенье"); break;
            default:            Console.WriteLine("это не день недели"); break;
        }
    }


    public string ReverseListNums(int x)
    {
        string result = "";
        for (int i = x; i >= 0; i--)
        {
            result += i;
            if (i > 0)
            {
                result += " ";
            }
        }
        return result;
    }


    public int Pow(int x, int y)
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        return result;
    }


    public bool EqualNum(int x)
    {
        int last = x % 10;
        x = x / 10;
        while (x > 0)
        {
            if (x % 10 != last) return false;
            x = x / 10;
        }
        return true;
    }


    public void LeftTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }


    public void GuessGame()
    {
        Random rnd = new Random();
        int target = rnd.Next(0, 10);
        int attempts = 0;
        int guess = -1;
        int value;

        while (guess != target)
        {
            Console.WriteLine("Введите число от 0 до 9:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out value) || value < 0 || value > 9)
            {
                Console.WriteLine("Ошибка! Нужно число от 0 до 9. Повторите.");
                continue;
            }

            guess = value;
            attempts++;

            if (guess == target)
            {
                Console.WriteLine("Вы угадали!");
            }
            else
            {
                Console.WriteLine("Вы не угадали, попробуйте ещё раз.");
            }
        }
        Console.WriteLine("Вы отгадали число за " + attempts + " попытки");
    }


    public int FindLast(int[] arr, int x)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }


    public int[] Add(int[] arr, int x, int pos)
    {
        int[] result = new int[arr.Length + 1];

        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }
        result[pos] = x;
        for (int i = pos; i < arr.Length; i++)
        {
            result[i + 1] = arr[i];
        }
        return result;
    }


    public void Reverse(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
    }


    public int[] Concat(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }
        return result;
    }
    
    
    public int[] DeleteNegative(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0) count++;
        }
        int[] result = new int[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                result[j] = arr[i];
                j++;
            }
        }
        return result;
    }
    
}

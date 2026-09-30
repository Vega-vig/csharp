
using  System;

internal class Program
{
    public static void Main(string[] args)
    {
        Tasks program = new Tasks();


        Console.WriteLine("Задача 1. Сумма знаков");
        Console.WriteLine("Введите как минимум двузначное число (пример 12, -134, 78564):");
        int x1,answ1;
        while (!int.TryParse(Console.ReadLine(), out x1) || (x1 > -10 && x1 < 10))
        {
            Console.WriteLine("Ошибка! Нужно целое число, по модулю не меньше 10. Повторите:");
        }
        answ1 = program.SumLastNums(x1);
        Console.WriteLine("Сумма двух последних знаков числа: " + answ1);
        
        
        Console.WriteLine("Задача 2. Есть ли позитив");
        Console.WriteLine("Введите любое целое число:");
        int x2;
        bool answ2;    
        while (!int.TryParse(Console.ReadLine(), out x2))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ2 = program.IsPositive(x2);
        Console.WriteLine("Число положительное? " + answ2);

        
        Console.WriteLine("Задача 3. Большая буква");
        Console.WriteLine("Введите одну букву (строчную или заглавную):");
        string namb3;
        bool answ3;
        char x3;
        namb3 = Console.ReadLine();
        while (namb3 == null || namb3.Length != 1)
        {
            Console.WriteLine("Ошибка! Введите ровно один символ. Повторите:");
            namb3 = Console.ReadLine();
        }
        x3 = Convert.ToChar(namb3);
        answ3 = program.IsUpperCase(x3);
        Console.WriteLine("Буква заглавная? " + answ3);

        
        Console.WriteLine("Задача 4. Делитель");
        Console.WriteLine("Введите первое число a:");
        int x4, y4;
        bool answ4;
        while (!int.TryParse(Console.ReadLine(), out x4))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите второе число b:");
        while (!int.TryParse(Console.ReadLine(), out y4))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ4 = program.IsDivisor(x4, y4);
        Console.WriteLine("Одно число делит другое нацело? " + answ4);
        
               
        Console.WriteLine("Задача 5. Многократный вызов");
        Console.WriteLine("Будем последовательно складывать последние цифры 5 чисел.");
        int x5 = 0, y5 = 0;
        int answ5;
        Console.WriteLine("Введите число 1:");
        while (!int.TryParse(Console.ReadLine(), out x5))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        for (int i = 2; i <= 5; i++)
        {
            Console.WriteLine("Введите число " + i + ":");
            while (!int.TryParse(Console.ReadLine(), out y5))
            {
                Console.WriteLine("Ошибка! Введите целое число. Повторите:");
            }
            answ5 = program.LastNumSum(x5, y5);
            Console.WriteLine(x5 + " + " + y5 + " это " + answ5);
            x5 = answ5;
        }
        Console.WriteLine("Итого " + x5);

      
        Console.WriteLine("Задача 6. Безопасное деление");
        int x6, y6;
        double answ6;
        Console.WriteLine("Введите x:");
        while (!int.TryParse(Console.ReadLine(), out x6))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите y:");
        while (!int.TryParse(Console.ReadLine(), out y6))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ6 = program.SafeDiv(x6, y6);
        Console.WriteLine("Результат деления: " + answ6);

         
        Console.WriteLine("Задача 7. Строка сравнения");
        int x7, y7;
        string answ7;
        Console.WriteLine("Введите x:");
        while (!int.TryParse(Console.ReadLine(), out x7))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите y:");
        while (!int.TryParse(Console.ReadLine(), out y7))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ7 = program.MakeDecision(x7, y7);
        Console.WriteLine("Результат: " + answ7);

 
        Console.WriteLine("Задача 8. Тройная сумма");
        int x8, y8, z8;
        bool answ8;
        Console.WriteLine("Введите x:");
        while (!int.TryParse(Console.ReadLine(), out x8))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите y:");
        while (!int.TryParse(Console.ReadLine(), out y8))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите z:");
        while (!int.TryParse(Console.ReadLine(), out z8))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ8 = program.Sum3(x8, y8, z8);
        Console.WriteLine("Можно сложить два числа и получить третье? " + answ8);
        
           
        Console.WriteLine("Задача 9. Возраст");
        int x9;
        string answ9;
        Console.WriteLine("Введите возраст (целое число от 0 до 150):");
        while (!int.TryParse(Console.ReadLine(), out x9) || x9 < 0 || x9 > 150)
        {
            Console.WriteLine("Ошибка! Введите целое число от 0 до 150. Повторите:");
        }
        answ9 = program.Age(x9);
        Console.WriteLine("Результат: " + answ9);

          
        Console.WriteLine("Задача 10. Вывод дней недели");
        string namb10;
        Console.WriteLine("Введите день недели (например: четверг):");
        namb10 = Console.ReadLine();
        while (namb10 == null || namb10.Trim().Length == 0)
        {
            Console.WriteLine("Ошибка! Строка пустая. Повторите:");
            namb10 = Console.ReadLine();
        }
        Console.WriteLine("Результат: ");
        program.PrintDays(namb10.Trim().ToLower());
    
        
        Console.WriteLine("Задача 11. Числа наоборот");
        int x11;
        string answ11;
        Console.WriteLine("Введите натуральное число x (от 0 до 1000):");
        while (!int.TryParse(Console.ReadLine(), out x11) || x11 < 0 || x11 > 1000)
        {
            Console.WriteLine("Ошибка! Введите целое число от 0 до 1000. Повторите:");
        }
        answ11 = program.ReverseListNums(x11);
        Console.WriteLine("Результат: " + answ11);

   
        Console.WriteLine("Задача 12. Степень числа");
        int x12, y12, answ12;
        Console.WriteLine("Введите основание x (целое число):");
        while (!int.TryParse(Console.ReadLine(), out x12))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите степень y (целое число от 0 до 10):");
        while (!int.TryParse(Console.ReadLine(), out y12) || y12 < 0 || y12 > 10)
        {
            Console.WriteLine("Ошибка! Введите целое от 0 до 10. Повторите:");
        }
        answ12 = program.Pow(x12, y12);
        Console.WriteLine("Результат: " + answ12);

            
        Console.WriteLine("Задача 13. Одинаковость");
        int x13;
        bool answ13;
        Console.WriteLine("Введите натуральное число (например 1111 или 1211):");
        while (!int.TryParse(Console.ReadLine(), out x13) || x13 <= 0)
        {
            Console.WriteLine("Ошибка! Введите целое положительное число. Повторите:");
        }
        answ13 = program.EqualNum(x13);
        Console.WriteLine("Все цифры одинаковы? " + answ13);

       
        Console.WriteLine("Задача 14. Левый треугольник");
        int x14;
        Console.WriteLine("Введите высоту треугольника (целое число от 1 до 50):");
        while (!int.TryParse(Console.ReadLine(), out x14) || x14 < 1 || x14 > 50)
        {
            Console.WriteLine("Ошибка! Введите целое от 1 до 50. Повторите:");
        }
        program.LeftTriangle(x14);

         
        Console.WriteLine("Задача 15. Угадайка");
        Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте угадать!");
        program.GuessGame();

  
        Console.WriteLine("Задача 16. Поиск последнего значения");
        int[] arr16 = ReadArray();
        int x16, answ16;
        Console.WriteLine("Введите искомое x:");
        while (!int.TryParse(Console.ReadLine(), out x16))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        answ16 = program.FindLast(arr16, x16);
        Console.WriteLine("Индекс последнего вхождения: " + answ16);

   
        Console.WriteLine("Задача 17. Добавление в массив");
        int[] arr17 = ReadArray();
        int x17, pos17;
        int[] answ17;
        Console.WriteLine("Введите значение x для вставки:");
        while (!int.TryParse(Console.ReadLine(), out x17))
        {
            Console.WriteLine("Ошибка! Введите целое число. Повторите:");
        }
        Console.WriteLine("Введите позицию pos (от 0 до " + arr17.Length + "):");
        while (!int.TryParse(Console.ReadLine(), out pos17) || pos17 < 0 || pos17 > arr17.Length)
        {
            Console.WriteLine("Ошибка! Введите целое от 0 до " + arr17.Length + ". Повторите:");
        }
        answ17 = program.Add(arr17, x17, pos17);
        Console.Write("Результат: ");
        PrintArray(answ17);
  
         
        Console.WriteLine("Задача 18. Реверс");
        int[] arr18 = ReadArray();
        Console.Write("Исходный массив: ");
        PrintArray(arr18);
        program.Reverse(arr18);
        Console.Write("После реверса:   ");
        PrintArray(arr18);

  
        Console.WriteLine("Задача 19. Объединение");
        Console.WriteLine("Введите первый массив:");
        int[] arr19a = ReadArray();
        Console.WriteLine("Введите второй массив:");
        int[] arr19b = ReadArray();
        int[] answ19 = program.Concat(arr19a, arr19b);
        Console.Write("Результат: ");
        PrintArray(answ19);


        Console.WriteLine("Задача 20. Удалить негатив");
        int[] arr20 = ReadArray();
        int[] answ20 = program.DeleteNegative(arr20);
        Console.Write("Результат: ");
        PrintArray(answ20);
       
    }

    public static int[] ReadArray()
    {
        int n;
        Console.WriteLine("Введите количество элементов массива (от 1 до 100):");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 100)
        {
            Console.WriteLine("Ошибка! Введите целое от 1 до 100. Повторите:");
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("arr[" + i + "]:");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Ошибка! Введите целое число. Повторите:");
            }
        }
        return arr;
    }


    public static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
    

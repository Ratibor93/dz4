// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

while (true)
    {
    Console.Write("Введите целое число или 'q' для выхода: ");
    string input = Console.ReadLine();

// Проверка на выход по символу 'q'
        if (input.ToLower() == "q")
        {
            Console.WriteLine("Программа завершена по запросу пользователя.");
            break;
        }

// Проверка на сумму цифр числа
    int number;
        if (int.TryParse(input, out number))
        {
        int sum = CalculateDigitSum(number);

        if (sum % 2 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
        }
    }

    static int CalculateDigitSum(int num)
    {
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
    }
//
// //  Задача 2: Задайте массив заполненный 
// //  случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // Прием размера массива
// System.Console.Write("Введите количетво элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());

// //  Создали отделбную область памети для массива с цель экономии памяти
// int[] myArray = new int[size];
// Random rand = new Random();

// //  Задали массив заполненный случайными трёхзначными числами.
// for (int i = 0; i < size; i++)
// myArray[i] = rand.Next(100, 1000);

// //  Ввели дополнительную переменную для подсчета четных чисел.
// int count=0;

// //  Выполняем условие которое покажет количество чётных чисел в массиве.
// for (int i = 0; i < size; i++)
// {
// if(myArray[i]%2==0) // тут мы проеверям на четность 
//     count++; // тут мы все введем подсчет четных чисел 
// Console.Write(myArray[i] + " "); // сдесь мы просим ввывесте в терменале массив 
// }
// Console.WriteLine($" => {count}"); // просим ввывести в терменале колличества четных чисел 


//  Задача 3 :Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)


// // Прием размера массива
// System.Console.Write("Введите количетво элементов в массиве: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int temp;

// //  Создали отделбную область памети для массива с цель экономии памяти
// int[] myArray = new int[size];
// Random rand = new Random();

// //  Задали массив заполненный случайными  числами.
// for (int i = 0; i < size; i++)
// {
//     myArray[i] = rand.Next(10);
//     Console.Write(myArray[i]+ " ");
// }

// for (int i = 0; i < size/2; i++)
// {
//     temp = myArray[i];
//     myArray[i] = myArray[size-1-i]; 
//     myArray[size-1-i] = temp;
// }
// Console.WriteLine();

// for (int i = 0; i < size; i++)
// Console.Write(myArray[i]+ " ");


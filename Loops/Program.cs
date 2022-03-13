using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Loop1: Дано целое неотрицательное число N. Найти число, составленное теми же десятичными цифрами,\n" +
            //    "что и N, но в обратном порядке. Запрещено использовать массивы.");
            //Console.WriteLine("Введите N");
            //var n1 = Console.ReadLine();
            //Console.WriteLine(Loop1.ReverseInt(Int32.Parse(n1)));

            //Console.WriteLine("Loops2. Дано N (1 ≤ N ≤ 27). Найти количество трехзначных натуральных чисел, сумма цифр которых \n" +
            //    "равна N. Операции деления (/, %) не использовать.");
            //Console.WriteLine("Ведите N");
            //var n2 = Console.ReadLine();
            //Console.WriteLine(Loop2.DoTask(Int32.Parse(n2)));

            //Console.WriteLine("Loops3. Если все числа натурального ряда записать подряд каждую цифру в своей позиции, то\n" +
            //    "необходимо ответить на вопрос: какая цифра стоит в заданной позиции N.");
            //Console.WriteLine("Ведите N");
            //var n3 = Console.ReadLine();
            //Console.WriteLine(Loop3.DoTask(Int32.Parse(n3)));

            Console.WriteLine("В массиве чисел найдите самый длинный подмассив из одинаковых чисел");
            Console.WriteLine(string.Join(" ", Loop4.array));
            var a = Loop4.FindLongestSubarray(Loop4.array);
            Console.WriteLine(string.Join(" ", a));


        }
    }
}

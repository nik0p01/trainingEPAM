using System;
using ArrayHelper;
using RectangleHelper;


namespace DemonstratesFunctional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 - сортировка пузырьком, 2 - сумма положительных элементов двумерного массива, 3 - площадь и периметр прямоугольника, 0 - выйти:  ");
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Это не целое число. Будет произведена выход");
                Console.ReadLine();
                return;
            }
            if (choice == 1)
            {
                Console.Write("Введите целые числа элементы массива для пузырьковой сортировки: ");
                var spilitArr = new[] { " ", ",", ";" };
                string[] parts = TackeStringArr(spilitArr);
                var arrayInt = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {

                    if (!int.TryParse(parts[i], out arrayInt[i]))
                    {
                        Console.WriteLine("Это не целое число: {0}. Будет произведена замена на 0", parts[i]);
                    }


                }
                arrayInt = ArrayHelper.SortArray.SortBubble(arrayInt);
                Console.WriteLine("Отсортированный массив в прямом порядке: {0}", string.Join(", ", arrayInt));
                arrayInt = ArrayHelper.SortArray.SortBubble(arrayInt, false);
                Console.WriteLine("Отсортированный массив в обратном порядке: {0}", string.Join(", ", arrayInt));
                Console.ReadLine();
                return;
            }
            if (choice == 2)
            {
                Console.Write("Введите целые числа элементов двухмерного массива для вычисления суммы всех целых значений: ");
                var spilitArr = new[] { " ", ",", ";" };
                string[] parts = TackeStringArr(spilitArr);
                if (parts.Length % 2 != 0)
                {
                    Console.WriteLine("Введеное не четное число элементов, лишние элементы будут не учтены");

                }
                var arrayInt = new int[parts.Length / 2, 2];

                for (int i = 0; i < parts.Length / 2; i++)
                {

                    for (int j = 0; j < 2; j++)
                    {
                        if (!int.TryParse(parts[i], out arrayInt[i, j]))
                        {
                            Console.WriteLine("Это не целое число: {0}. Будет произведена замена на 0", parts[i]);
                        }
                    }
                }

                Console.WriteLine("Сумма положительных элементорв двумерного массива: {0}", ArrayHelper.SumPositiveElementsClass.GetSumPositiveElements(arrayInt) ?? 0);
                Console.ReadLine();
                return;
            }
            if (choice == 3)
            {
                Console.Write("Введите высоту и ширину прямоугольника: ");
                var spilitArr = new[] { " ",  ";" };
                string[] parts = TackeStringArr(spilitArr);
                double h=0;
                double w=0;
                if (parts.Length < 2)
                {
                    Console.Write("Значения не введены");
                    return;
                }

                for (int i = 0; i < 2; i++)
                {
                    if (!double.TryParse(parts[i], out double res))
                    {
                        Console.WriteLine("Это не число: {0}. Будет произведена замена на 0", parts[i]);
                    }
                    if (i == 0)
                    {
                        w = res;
                    }
                    else
                    {
                        h = res;
                    }
                }

                Rectangle rAH;
                try
                {
                     rAH = new Rectangle(w, h);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Возникла ошибка: {0}", e.Message);
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("Периметр: {0}, площадь: {1}", rAH.Perimeter(), rAH.Square());
                Console.ReadLine();
                return;
            }
        }

        private static string[] TackeStringArr(string[] spilitArr )
        {
            return Console.ReadLine().Split(spilitArr, StringSplitOptions.RemoveEmptyEntries);
        }



    }
}

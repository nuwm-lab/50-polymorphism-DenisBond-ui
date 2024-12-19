        using System;

namespace PolymorphismExample
    {
        class Vector1D
        {
            protected int[] elements = new int[4];
            public virtual void SetElements()
            {
                Console.WriteLine("Введiть 4 елементи вектора:");
                for (int i = 0; i < elements.Length; i++)
                {
                    elements[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            public virtual void ShowElements()
            {
                Console.WriteLine("Вектор:");
                foreach (var element in elements)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            public virtual int FindMaxElement()
            {
                int max = elements[0];
                foreach (var element in elements)
                {
                    if (element > max)
                        max = element;
                }
                Console.WriteLine("Максимальний елемент вектора: " + max);
                return max;
            }
        }
        class Matrix4x4 : Vector1D
        {
            private int[,] matrix = new int[4, 4];
            public override void SetElements()
            {
                Console.WriteLine("Введiть елементи матрицi 4x4:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"Елемент [{i}][{j}]: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            public override void ShowElements()
            {
                Console.WriteLine("Матриця:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            public override int FindMaxElement()
            {
                int max = matrix[0, 0];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[i, j] > max)
                            max = matrix[i, j];
                    }
                }
                Console.WriteLine("Максимальний елемент матрицi: " + max);
                return max;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Vector1D obj;
                int userChoice;
                do
                {
                    Console.WriteLine("Виберiть тип об'єкта для роботи: ");
                    Console.WriteLine("1 - Одновимiрний вектор");
                    Console.WriteLine("2 - Матриця");
                    Console.WriteLine("0 - Вихiд");
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice == 1)
                    {
                        obj = new Vector1D();
                    }
                    else if (userChoice == 2)
                    {
                        obj = new Matrix4x4();
                    }
                    else
                    {
                        break;
                    }
                    obj.SetElements();
                    obj.ShowElements();
                    obj.FindMaxElement();
                } while (userChoice != 0);
                Console.WriteLine("Програма завершена.");
            }
        }
    }


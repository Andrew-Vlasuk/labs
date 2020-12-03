using System;

namespace LAb2
{
    public class Matrix
    {
        public static int Size = 3;
        public int[,] A = new int[Size, Size];
        public Matrix() { }
        public void FillMatrix()
        {
            Random rn = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    A[i, j] = rn.Next(1, 15);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write("{0,4}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Sum();
        }
        public void Sum()
        {
            int sum = 0;
            Console.WriteLine("Sum of diagonal elements");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        sum += A[i, j];
                    }
                }
            }
            Console.WriteLine("Sum: " + sum);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.FillMatrix();
            matrix.Print();

        }
    }
}

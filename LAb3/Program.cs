using System;
using System.Threading;

namespace LAb3
{
    public class Matrix
    {
        public static int Size = 3;
        public int DiaSum { get; set; }
        public int[,] A = new int[Size, Size];
        public Matrix() { FillMatrix(); }
        public void FillMatrix()
        {
            Random rn = new Random();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    A[i, j] = rn.Next(1, 15);
                    Thread.Sleep(1);
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
        public int Sum()
        {
            Console.WriteLine("Sum of diagonal elements");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        DiaSum += A[i, j];
                    }
                }
            }
            Console.WriteLine("Sum: " + DiaSum);
            return DiaSum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Matrix matrix2 = new Matrix();
            Matrix matrix3 = new Matrix();
            Matrix[] matrices = new Matrix [3];
            matrices[0] = matrix1;
            matrices[1] = matrix2;
            matrices[2] = matrix3;
            foreach(Matrix item in matrices)
            {
                item.Print();
            }
            Console.WriteLine();
           if(matrix1.DiaSum > matrix2.DiaSum && matrix1.DiaSum > matrix3.DiaSum)
                Console.WriteLine($"Max sum has fist matrix: {matrix1.DiaSum}");
           else if (matrix2.DiaSum > matrix1.DiaSum && matrix2.DiaSum > matrix3.DiaSum)
                Console.WriteLine($"Max sum has second matrix: {matrix2.DiaSum}");
            else if (matrix3.DiaSum > matrix1.DiaSum && matrix3.DiaSum > matrix2.DiaSum)
                Console.WriteLine($"Max sum has third matrix: {matrix3.DiaSum}");

        }
    }
}

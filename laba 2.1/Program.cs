using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int[,] arr = new int[N,N];
            FillingArray(arr);
            Console.WriteLine("Старый массив\n");
            OutPutArray(arr);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (arr[i,j] != 1)
                    ChangeArray(arr, i, j);
                }
            }
            Console.WriteLine("Новый массив\n");
            OutPutArray(arr);
            Console.ReadKey();
        }
        static int ChangeArray(int[,] arr , int ni, int nj)
        {
            for (int i = Math.Max(0, ni - 1); i < Math.Min(ni + 2, arr.GetLength(0)); i++) 
            {
                for (int j = Math.Max(0, nj - 1); j < Math.Min(nj + 2, arr.GetLength(1)); j++) 
                {
                    if (i == ni && j == nj)
                    {
                        continue;
                    }
                    if (arr[i,j] == 1)
                    {
                        arr[ni, nj] = 0;
                        break;
                    }
                }
            }
            return arr[ni, nj];
        }
        static void FillingArray(int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = random.Next(1,9);
                }
            }
        }
        static void OutPutArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

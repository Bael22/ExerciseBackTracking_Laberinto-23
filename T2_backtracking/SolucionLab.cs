using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_backtracking
{
    internal class SolucionLab
    {
        public static void Imprime(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "-");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static bool ValidarLab(int[,] a, int[,] b, int fila, int col, ref int suma)
        {
            if (fila < 0 || fila >= a.GetLength(0)) 
                return false;
            if (col < 0 || col >= a.GetLength(1)
                || a[fila, col] == 0 || b[fila, col] != 0)
                    return false;
            if (a[fila, col] != 1) suma += a[fila, col];
            b[fila, col] = a[fila, col];
            return true;
        }
        public static bool SolLab(int[,] a, int[,] b, int fila, int col, ref int suma)
        {
            if (suma >= 23 && fila == 0 && col == 0)
                return true;
            else
            {
                //imprime(b);

                if (ValidarLab(a, b, fila - 1, col, ref suma) && SolLab(a, b, fila - 1, col, ref suma))//arr
                    return true;
                else if (ValidarLab(a, b, fila, col + 1, ref suma) && SolLab(a, b, fila, col + 1, ref suma))//der
                    return true;
                else if (ValidarLab(a, b, fila + 1, col, ref suma) && SolLab(a, b, fila + 1, col, ref suma))//aba
                    return true;
                else if (ValidarLab(a, b, fila, col - 1, ref suma) && SolLab(a, b, fila, col - 1, ref suma))//izq
                    return true;
                else
                {
                    if (a[fila, col] != 1)
                     suma -= a[fila, col]; 
                    b[fila, col] = 0;
                    return false;
                }

            }
        }
    }
}

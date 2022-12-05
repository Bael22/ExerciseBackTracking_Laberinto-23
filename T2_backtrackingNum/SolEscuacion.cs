using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_backtrackingNum
{
    internal class SolEscuacion
    {
        public static bool Correjir(int total, int suma)
        {
            if (total < suma)
            {

                return false;
            }
            else
            {
                return true;
            }

        }
        public static bool ResolucionEc(int[] arr, int puesto, int suma, int total, ref string var)
        {
            if (puesto == 5 && suma == total && suma > 0)
            {
                return true;
            }
            else
            {
                if (puesto < 5)
                {
                    
                    if (Correjir(total, suma * arr[puesto]) && ResolucionEc(arr, puesto + 1, suma * arr[puesto], total, ref var))
                    {//multiplicar
                        var = "*" + arr[puesto] + var;
                        --puesto;
                        return true;

                    }
                    else if (Correjir(total, suma - arr[puesto]) && ResolucionEc(arr, puesto + 1, suma - arr[puesto], total, ref var))
                    {//resta
                        var = "-" + arr[puesto] + var;
                        --puesto;
                        return true;
                    }
                    else if (Correjir(total, suma + arr[puesto]) && ResolucionEc(arr, puesto + 1, suma + arr[puesto], total, ref var))
                    {//suma
                        var = "+" + arr[puesto] + var;
                        --puesto;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }
    }
}

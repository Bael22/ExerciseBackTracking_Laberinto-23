

int[,] lab = {
    {1,1,1,3,0,1,1,1,4 },
    {3,0,0,1,0,1,0,0,1 },
    {1,1,0,1,1,1,1,0,1 },
    {0,1,0,1,0,0,1,0,1 },
    {1,1,1,1,1,1,3,1,1 },
    {3,0,1,0,0,0,1,0,1 },
    {1,1,1,1,3,1,1,1,1 },
    {1,0,0,1,0,1,0,0,4 },
    {1,1,3,1,0,1,1,1,1 },
};
int[,] mat = {
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
    {0,0,0,0,0,0,0,0,0 },
};
Console.WriteLine("Matriz inicial");
for (int i = 0; i < lab.GetLength(0); i++)
{
    for (int j = 0; j < lab.GetLength(1); j++)
        Console.Write(lab[i, j] + ",");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Matriz Final");
int suma = 0;
Console.WriteLine();
if (T2_backtracking.SolucionLab.SolLab(lab, mat, 8, -1, ref suma))
    Console.WriteLine("Si se pudo salir\n" + "Suma total: "+suma);
else
    Console.WriteLine("No se pudo salir\n" + "Suma total: " + suma);
Console.WriteLine();
for (int i = 0; i < lab.GetLength(0); i++)
{
    for (int j = 0; j < lab.GetLength(1); j++)
        Console.Write(mat[i, j] + ",");
    Console.WriteLine();
}
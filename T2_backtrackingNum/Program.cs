
int[] arr = new int[5];
Console.WriteLine("Ingrese respuesta de su proximo arreglo: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Registre 5 numeros para su arreglo: ");
for (int i = 0; i < arr.Length; i++)
{

    arr[i] = int.Parse(Console.ReadLine());

    Console.WriteLine();
}

string aux = "";
int posicion = 1;
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + ", ");
}
Console.WriteLine();
T2_backtrackingNum.SolEscuacion.ResolucionEc(arr, posicion, arr[0], num, ref aux);

Console.WriteLine("\n"+arr[0] + aux + " = "+num);
if(Int32.TryParse(aux, out int j))
    Console.WriteLine(j);



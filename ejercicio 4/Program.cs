Console.WriteLine("ingrese las proporciones del arreglo");
int numero = Convert.ToInt32(Console.ReadLine());
int[] listado = new int[numero];
for (int i = 0; i < listado.Length; i++)
{
    Console.WriteLine("ingrese un numero");
    listado[i] = Convert.ToInt32(Console.ReadLine());

}
int opcion = 0;
Boolean Salir = false;
do
{
    Console.WriteLine("1Imprimir y Ordenar el arreglo");
    Console.WriteLine("2Buscar un numero del arreglo");
    Console.WriteLine("3Salir");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            listado = BubbleSort(listado);
            imprimir(listado);
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("ingrese un numero ");
            int posicion = Convert.ToInt32(Console.ReadLine());
            int guardar = BusquedaBinaria(listado, posicion);
            if (guardar == -1)
            {
                Console.WriteLine("no existe el numero que buscas");
            }
            else
            {
                Console.WriteLine("el numero " + posicion + " esta en la posicion " + guardar);
            }
            break;

        case 3:
            Console.Clear();
            Salir = true;
            break;
        default:
            {
                Console.WriteLine("Error usted no sabe lo que hace");
                break;
            }
    }

} while (!Salir);

static int[] BubbleSort(int[] array)
{
    int n = array.Length;
   
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}


void imprimir(int[] arreglo)
{
    foreach (var item in arreglo)
    {
        Console.WriteLine(item);
    }
}

static int BusquedaBinaria(int[] arreglo, int elemento)
{
    int inicio = 0;
    int fin = arreglo.Length - 1;

    while (inicio <= fin)
    {
        int medio = inicio + (fin - inicio) / 2;

        if (arreglo[medio] == elemento)
        {
            return medio;
        }

        if (arreglo[medio] > elemento)
        {
            fin = medio - 1;
        }  
        else
        {
            inicio = medio + 1;
        }
    }
    return -1;
}

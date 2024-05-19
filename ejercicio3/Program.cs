string[] listado = { "andres", "cintia", "mario", "milagros", "tilin", "Kennet", "angel" };

Console.WriteLine("ingresar un nombre para buscarlo");

string nombre = Console.ReadLine();

int guardar = Buscar(listado, nombre);

if (guardar == -1)
{
    Console.WriteLine("nombre no existe en este arreglo");
}
else
{
    Console.WriteLine("El nombre " + nombre + " se encuentra en la posicion " + guardar + " del arreglo");
}



static int Buscar(string[] arreglo, string elemento)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == elemento)
        {
            return i; 
        }
    }
    return -1; 
}

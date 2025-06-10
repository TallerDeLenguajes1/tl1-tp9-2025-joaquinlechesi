// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string path;
do
{
    Console.WriteLine("Ingrese la direccion/path que desee manipular o '0' para finalizar:");
    path = Console.ReadLine();
    Console.WriteLine("Directorio ingresado:\n" + path);
    if (Directory.Exists(path))
    {
        // Directory.GetDirectories(path);
        string[] directorios = Directory.GetDirectories(path);
        // string[] archivos = 
        Console.WriteLine("Subdirectorios:");
        for (int i = 0; i < directorios.Length; i++)
        {
            Console.WriteLine(directorios[i]);
        }
    }
    else
    {
        Console.WriteLine("El directorio no existe.");
    }
} while (!Directory.Exists(path) && path != "0");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string path;
Console.WriteLine("Ingrese la direccion/path que desee manipular:");
path = Console.ReadLine();
do
{
    if (!File.Exists(path))
    {
        Console.WriteLine("El directorio no existe.");
    }
    else
    {
        // Directory.GetDirectories(path);
        string[] directorios = Directory.GetDirectories(path);
        Console.WriteLine("Subdirectorios:");
        for (int i = 0; i < directorios.Length; i++)
        {
            Console.WriteLine(directorios[i]);
        }
    }
} while (!File.Exists(path));
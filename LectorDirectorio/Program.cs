// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string path;
do
{
    Console.WriteLine("Ingrese la direccion/path que desee manipular o '0' para finalizar:");
    path = Console.ReadLine();
    Console.WriteLine("Directorio ingresado:\n" + path + "\n");
    if (Directory.Exists(path))
    {
        // Directory.GetDirectories(path);
        string[] directorios = Directory.GetDirectories(path);
        string[] archivos = Directory.GetFiles(path);
        Console.WriteLine("Subdirectorios:");
        for (int i = 0; i < directorios.Length; i++)
        {
            Console.WriteLine(directorios[i]);
        }
        Console.WriteLine("Archivos:");
        for (int i = 0; i < archivos.Length; i++)
        {
            FileInfo info = new FileInfo(archivos[i]);
            long tamanioKB = info.Length;
            Console.WriteLine("Nombre del archivo:" + archivos[i] + " , tamaño: " + (tamanioKB / 1024) + "KB");
        }
        string archivoCrear = path + "\\reporte_archivos.csv";
        File.Create(archivoCrear);
        // if (true)
        // {

        // }
        FileInfo archivoCreado = new FileInfo(archivoCrear);
        var estado = File.OpenWrite(archivoCrear);
        //estado.Write()
    }
    else
    {
        Console.WriteLine("El directorio no existe.");
    }
} while (!Directory.Exists(path) && path != "0");
Console.WriteLine("Fin del programa.");
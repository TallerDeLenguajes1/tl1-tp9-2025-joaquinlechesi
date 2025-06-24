// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;
using System.ComponentModel;
using LectorDirectorio;

Console.WriteLine("Ejercicio 1");

string path;
do
{
    Console.WriteLine("Ingrese la direccion/path que desee manipular o '0' para finalizar:\nEjemplor de un path:\nC:\\Users\\joaqu\\Facultad\\2025");
    path = Console.ReadLine();
    if (path != "0")
    {
        Console.WriteLine("Directorio ingresado:\n" + path + "\n");
    }
    if (Directory.Exists(path)) // Directory porporciona metodos estadicos
    {
        // Directory.GetDirectories(path);
        string[] directorios = Directory.GetDirectories(path); // Lista de todas las carpetas dentro del path
        string[] archivos = Directory.GetFiles(path); // Lista de todos los archivos dentro del path
        Console.WriteLine("Subdirectorios:");
        for (int i = 0; i < directorios.Length; i++)
        {
            Console.WriteLine(directorios[i]); // Escribo por consola todas las carpetas dentro del path
        }
        Console.WriteLine("Archivos:");
        for (int i = 0; i < archivos.Length; i++)
        {
            FileInfo info = new FileInfo(archivos[i]); // FileInfo proporciona metodos de instancia
            long tamanioKB = info.Length;
            Console.WriteLine("Nombre del archivo:\n" + archivos[i] + " , tamaño: " + (tamanioKB / 1024) + "KB"); // Escribo por consola todos los archivos dentro del path
        }
        string ruta = "Archivos\\reporte_archivos.csv";
        Archivo.guardarArchivo(ruta, archivos); // clase estatica
        //var nuevoArchivo = new Archivo();
        //nuevoArchivo.guardarArchivo(ruta, archivos);
        // FileStream archivo = File.Create(archivoCrear); // se puede emplear la using
        // FileInfo informacionArchivo = new FileInfo(archivoCrear);
        // string nombreArchivo = informacionArchivo.Name;
        // long tamanioArchivoKB = informacionArchivo.Length / 1024;
        // DateTime ultimaModificacion = informacionArchivo.LastWriteTime;
        // archivo.Close();
        // StreamWriter archivoEscribir = new StreamWriter(archivoCrear);
        // archivoEscribir.WriteLine($"{nombreArchivo},{Decimal.Round(tamanioArchivoKB, 2)}KB,{ultimaModificacion.ToString()}"); // escribre en el acchivo
        // archivoEscribir.Close();
    }
    else
    {
        if (path != "0")
        {
            Console.WriteLine("El directorio no existe.");
        }
    }
} while (!Directory.Exists(path) && path != "0");
Console.WriteLine("Fin del programa.");
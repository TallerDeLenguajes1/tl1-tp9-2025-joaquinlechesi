// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 2.");

string archivoLectura = "C:\\Users\\joaqu\\Facultad\\2025\\Taller de Lenguajes I\\Semana_09\\08 - Mysterious Ways.mp3";

if (File.Exists(archivoLectura))
{
    Console.WriteLine("Archivo con el que se trabajará:\n" + archivoLectura);
    FileStream archivo = File.Open(archivoLectura, FileMode.Open);
    byte[] buffer = new byte[128];
    int lectura = archivo.Read(buffer);
    
    //archivo.Seek(0, SeekOrigin.End);
    //var bytesLectura = FileStream.Read(archivo, 0);
}

Console.WriteLine("Fin del programa.");

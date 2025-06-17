using LectorTagMP3;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 2.");

string archivoLectura = "C:\\Users\\joaqu\\Facultad\\2025\\Taller de Lenguajes I\\Semana_09\\08 - Mysterious Ways.mp3";

if (File.Exists(archivoLectura))
{
    Console.WriteLine("Archivo con el que se trabajará:\n" + archivoLectura);
    FileStream archivo = File.Open(archivoLectura, FileMode.Open);
    byte[] buffer = new byte[128]; // Consultar si esta relacionado con los ultimos 128 bytes del archivo
    archivo.Seek(-128, SeekOrigin.End);
    archivo.Read(buffer, 0, 128);
    System.Text.Encoding.GetEncoding("latin1");
    var headerMP3 = System.Text.Encoding.Default.GetString(buffer, 0, 3);
    var tituloMP3 = System.Text.Encoding.Default.GetString(buffer, 3, 30);
    var artistaMP3 = System.Text.Encoding.Default.GetString(buffer, 33, 30);
    var albumMP3 = System.Text.Encoding.Default.GetString(buffer, 63, 30);
    var anioMP3 = System.Text.Encoding.Default.GetString(buffer, 93, 4);
    var comentarioMP3 = System.Text.Encoding.Default.GetString(buffer, 97, 30);
    var generoMP3 = System.Text.Encoding.Default.GetString(buffer, 127, 1);
    //Console.WriteLine($"{headerMP3} - {artistaMP3} - {tituloMP3} - {albumMP3} - {anioMP3} - {comentarioMP3} - {generoMP3}");
    Id3v1Tag tag;
    tag = new Id3v1Tag(tituloMP3, artistaMP3, albumMP3, anioMP3, comentarioMP3, generoMP3);
    Console.WriteLine($"{tag.Artista} - {tag.Nombre} - {tag.Album} - {tag.Anio}");
    //archivo.Seek(0, SeekOrigin.End);
    //var bytesLectura = FileStream.Read(archivo, 0);
}

Console.WriteLine("Fin del programa.");
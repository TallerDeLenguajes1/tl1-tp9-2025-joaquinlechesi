namespace LectorDirectorio;

public static class Archivo  //estatico
{
    public static void guardarArchivo(string ruta, string[] archivos)
    {
        FileStream fs = new FileStream(ruta, FileMode.Create);
        using (StreamWriter str = new StreamWriter(fs))
        {
            str.WriteLine("Nombre, Tamanio");
            foreach (var item in archivos)
            {
                //string nombre = Path.GetFileName(item);
                FileInfo info = new FileInfo(item);
                long tamanio = info.Length;
                str.WriteLine($"{item} , {tamanio}");
            }
            //archivoEscribir.WriteLine($"{nombreArchivo},{Decimal.Round(tamanioArchivoKB, 2)}KB,{ultimaModificacion.ToString()}");
            str.Close(); // cierra el archivo
        }
        // {
        //     //fs.WriteLine("");
        // }
    }
        
}
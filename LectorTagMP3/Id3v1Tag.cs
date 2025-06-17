namespace LectorTagMP3;

public class Id3v1Tag
{
    private string nombre;
    private string artista;
    private string album;
    private string anio;
    private string comentario;
    private string genero;
    public Id3v1Tag(string nombre_constructor, string artista_constructor, string album_constructor, string anio_constructor, string comentario_constructor, string genero_construnctor)
    {
        this.nombre = nombre_constructor;
        this.artista = artista_constructor;
        this.album = album_constructor;
        this.anio = anio_constructor;
        this.comentario = comentario_constructor;
        this.genero = genero_construnctor;
    }
    public string Nombre
    {
        get => nombre;
    }
    public string Artista
    {
        get => artista;
    }
    public string Album
    {
        get => album;
    }
    public string Anio
    {
        get => anio;
    }
}
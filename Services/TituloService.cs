public class TituloService
{
    private static List<Titulo> titulos = new();
    private static int contador = 1;

    public Titulo Criar(Titulo titulo)
    {
        titulo.Id = contador++;
        titulo.Status = "Registrado";
        titulos.Add(titulo);
        return titulo;
    }

    public Titulo Baixar(int id)
    {
        var titulo = titulos.FirstOrDefault(t => t.Id == id);
        if (titulo != null) titulo.Status = "Baixado";
        return titulo;
    }

    public Titulo Cancelar(int id)
    {
        var titulo = titulos.FirstOrDefault(t => t.Id == id);
        if (titulo != null) titulo.Status = "Cancelado";
        return titulo;
    }

    public Titulo Obter(int id) => titulos.FirstOrDefault(t => t.Id == id);
    public List<Titulo> Listar() => titulos;
}
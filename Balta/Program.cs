using Balta.ContextoConteudo;

internal class Program
{
    static void Main(string[] args)
    {
        var artigos = new List<Artigo>
        {
            new Artigo("Artigo sobre OOP", "orientacao-objetos"),
            new Artigo("Artigo sobre C#", "csharp"),
            new Artigo("Artigo sobre .NET", "dotnet")
        };

        //foreach (var artigo in artigos)
        //{
        //    Console.WriteLine(artigo.Codigo);
        //    Console.WriteLine(artigo.Titulo);
        //    Console.WriteLine(artigo.Url);
        //}

        var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-orientacao-objetos");
        var cursoCSharp = new Curso("Fundamentos C#", "fundamentos-csharp");
        var cursoAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

        var cursos = new List<Curso>
        {
            cursoOOP, cursoCSharp, cursoAspNet
        };

        var carreiraDotNet = new Carreira("Especialista .NET", "especialista-dotnet");
        var itemCarreira = new ItemCarreira(1, "Comece por aqui", "Teste", cursoCSharp);
        var itemCarreira3 = new ItemCarreira(3, "Aprenda .NET", "Teste", cursoAspNet);
        var itemCarreira2 = new ItemCarreira(2, "Aprenda OOP", "Teste", cursoAspNet);
        carreiraDotNet.Items.Add(itemCarreira);
        carreiraDotNet.Items.Add(itemCarreira3);
        carreiraDotNet.Items.Add(itemCarreira2);
        var carreiras = new List<Carreira> {
            carreiraDotNet
        };

        foreach (var carreira in carreiras)
        {
            Console.WriteLine(carreira.Titulo);
            foreach (var item in carreira.Items.OrderBy(x => x.Ordem))
            {
                Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                Console.WriteLine($"{item.Cursos.Titulo}");
                Console.WriteLine($"{item.Cursos.Nivel}");
            }
        }

    }
}
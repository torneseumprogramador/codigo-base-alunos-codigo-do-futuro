using Basico.Interces;
using Basico.Models;

namespace Basico.Servicos;

public class GenericoServico
{
    public static void ImprimeNome(IObjeto iObjeto)
    {
        Console.WriteLine($"O nome é: {iObjeto.Nome}, da classe {iObjeto.ToString()}");
    }

    public static void ImprimeNomeComSwitch(object objeto)
    {
        var nome = "";
        switch (objeto.GetType().Name)
        {
            case "Cliente":
                nome = ((Cliente)objeto).Nome;
                break;
            case "Fornecedor":
                nome = ((Fornecedor)objeto).Nome;
                break;
            default:
                nome = "Tipo não encontrado";
                break;
        }

        Console.WriteLine($"O nome é: {nome}");
    }

    public static void ImprimeNomeSemInterface(object objeto)
    {
        Console.WriteLine($"O nome é: {objeto.ToString()}");
    }

    public static void ImprimeNomeComReflaction(object objeto)
    {
        var nome = objeto.GetType().GetProperty("Nome")?.GetValue(objeto);
        Console.WriteLine($"O nome é: {nome}");
    }
}
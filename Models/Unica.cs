using Basico.Interces;

namespace Basico.Models;

public class Unica
{
    private Unica(){ }
    private static Unica unica = new Unica();
    public static Unica Get()
    { 
        return unica;
    }

    public string Teste { get;set; } = default!;
    public string Teste2 { get;set; } = default!;
}

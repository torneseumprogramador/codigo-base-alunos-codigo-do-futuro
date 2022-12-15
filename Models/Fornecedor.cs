using Basico.Interces;

namespace Basico.Models;

public class Fornecedor : IObjeto
{
    public string Nome { get;set; } = default!;
    public string Telefone { get;set; } = default!;

    public override string? ToString()
    {
        return this.Nome;
    }
}

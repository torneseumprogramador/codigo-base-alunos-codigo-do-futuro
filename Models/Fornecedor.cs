using Basico.Interces;

namespace Basico.Models;

public sealed class Fornecedor : Pessoa
{
    public Fornecedor() { }
    public Fornecedor(string nome): base(nome){ }

    public override string? ToString()
    {
        return this.Nome;
    }

    public override string NomeMinusculo()
    {
        return this.Nome.ToLower();
    }

    public override string NomeMaiusculo()
    {
        return this.Nome.ToUpper() + " --- " + base.NomeMaiusculo();
    }
}

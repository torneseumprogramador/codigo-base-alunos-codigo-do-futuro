using Basico.Interces;

namespace Basico.Abstracao;

public abstract class AObjeto : IObjeto
{
    public string Nome {get; set;} = default!;

    public abstract string NomeMaiusculo();
    public virtual string NomeMinusculo()
    {
        return this.Nome.ToLower();
    }
}
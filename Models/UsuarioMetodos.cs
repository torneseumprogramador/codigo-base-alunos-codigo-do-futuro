using Basico.Interces;

namespace Basico.Models;

public partial class Usuario
{
    public string NomeMaiusculo()
    {
        this.ClientePorCompleto3();
        return this.Nome.ToUpper();
    }

    public string NomeMinusculo()
    {
        return this.Nome.ToUpper();
    }
}

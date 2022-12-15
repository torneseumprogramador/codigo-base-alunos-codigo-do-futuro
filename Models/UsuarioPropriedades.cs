using Basico.Interces;

namespace Basico.Models;

public partial class Usuario : Cliente
{
    public new string Nome { get;set; } = default!;
    public new string Telefone { get;set; } = default!;
}

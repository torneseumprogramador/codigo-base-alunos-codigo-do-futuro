namespace Basico.Models;
using Basico.Abstracao;

public class Pessoa : AObjeto
{
    public Pessoa(){ }
    public Pessoa(string nome)
    {
        this.Nome = nome;
    }

    public override string NomeMaiusculo()
    {
        return this.Nome.ToUpper() + " - Classe Pessoa";
    }

    public override string NomeMinusculo()
    {
        return this.Nome.ToLower();
    }
}
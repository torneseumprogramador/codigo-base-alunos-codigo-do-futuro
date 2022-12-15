using Basico.Interces;

namespace Basico.Models;

public class Cliente : Pessoa, IObjeto
{
    public Cliente(){ }
    public Cliente(string _nome)
    { 
        var lista = new List<Cliente>();
        this.Nome = _nome;
    }
    public Cliente(string _nome, string _telefone)
    { 
        this.Nome = _nome;
        this.Telefone = _telefone;
    }

    public string MetodoComDoisParametros(string nome, string sobrenome)
    {
        return $"{nome} {sobrenome}";
    }

    public string Telefone { get;set; } = default!;

    public override string? ToString()
    {
        return this.Nome;
    }

    public string ClientePorCompleto()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

    public string ClientePorCompleto(string mensagem)
    {
        return $"{mensagem} - Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

    internal string ClientePorCompleto2()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

    protected string ClientePorCompleto3()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

    private string ClientePorCompleto4()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

    public override string NomeMaiusculo()
    {
        return this.Nome.ToUpper();
    }

    public override string NomeMinusculo()
    {
        return this.Nome.ToUpper();
    }
}

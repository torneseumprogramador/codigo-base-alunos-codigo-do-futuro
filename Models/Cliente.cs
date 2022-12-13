namespace Basico.Models;

public class Cliente 
{
    public Cliente(){ }
    public Cliente(string _nome)
    { 
        this.Nome = _nome;
    }
    public Cliente(string _nome, string _telefone)
    { 
        this.Nome = _nome;
        this.Telefone = _telefone;
    }

    public string Nome { get;set; } = default!;
    public string Telefone { get;set; } = default!;

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
}

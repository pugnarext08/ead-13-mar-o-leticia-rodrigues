using System;

public class Software
{
    public string Nome { get; set; } = string.Empty;
    public string Versao { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public Software() { }

    public Software(string nome, string versao, decimal preco)
    {
        Nome = nome;
        Versao = versao;
        Preco = preco;
    }
}

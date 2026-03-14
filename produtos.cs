using System;

public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto() { }

    public Produto(string nome, string categoria, decimal preco, int quantidade)
    {
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
        Quantidade = quantidade;
    }
}

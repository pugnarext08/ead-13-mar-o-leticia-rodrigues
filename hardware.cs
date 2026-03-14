using System;

public class Hardware
{
    public string Nome { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty; // Ex: Placa de vídeo, RAM
    public string Fabricante { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Hardware() { }

    public Hardware(string nome, string tipo, string fabricante, decimal preco, int quantidade)
    {
        Nome = nome;
        Tipo = tipo;
        Fabricante = fabricante;
        Preco = preco;
        Quantidade = quantidade;
    }
}

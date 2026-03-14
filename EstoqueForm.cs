using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class EstoqueForm : Form
{
    private List<Produto> produtos = new List<Produto>();
    private List<Software> softwares = new List<Software>();
    private List<Hardware> hardwares = new List<Hardware>();

    // Botões
    private Button btnAddProduto, btnAddSoftware, btnAddHardware;

    // DataGridViews
    private DataGridView dgvProdutos, dgvSoftwares, dgvHardwares;

    // TextBoxes para cadastro
    private TextBox txtNomeProduto, txtCategoriaProduto, txtPrecoProduto, txtQtdProduto;
    private TextBox txtNomeSoftware, txtVersaoSoftware, txtPrecoSoftware;
    private TextBox txtNomeHardware, txtTipoHardware, txtFabricanteHardware, txtPrecoHardware, txtQtdHardware;

    // Labels de total
    private Label lblTotalProdutos, lblTotalSoftwares, lblTotalHardwares;

    public EstoqueForm()
    {
        this.Text = "Sistema de Controle de Estoque";
        this.Width = 900;
        this.Height = 700;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor = Color.LightGray;

        Font fontePadrao = new Font("Segoe UI", 9);

        // ---------- PRODUTOS ----------
        GroupBox gbProduto = new GroupBox
        {
            Text = "Produtos",
            Top = 10,
            Left = 10,
            Width = 860,
            Height = 200,
            Font = fontePadrao
        };
        this.Controls.Add(gbProduto);

        // Campos
        Label lblNomeProduto = new Label { Text = "Nome:", Top = 25, Left = 10, Width = 50 };
        txtNomeProduto = new TextBox { Top = 22, Left = 70, Width = 150 };
        Label lblCategoriaProduto = new Label { Text = "Categoria:", Top = 25, Left = 230, Width = 60 };
        txtCategoriaProduto = new TextBox { Top = 22, Left = 300, Width = 150 };
        Label lblPrecoProduto = new Label { Text = "Preço:", Top = 25, Left = 460, Width = 40 };
        txtPrecoProduto = new TextBox { Top = 22, Left = 510, Width = 80 };
        Label lblQtdProduto = new Label { Text = "Qtd:", Top = 25, Left = 600, Width = 30 };
        txtQtdProduto = new TextBox { Top = 22, Left = 640, Width = 60 };

        btnAddProduto = new Button { Text = "Adicionar Produto", Top = 20, Left = 720, Width = 120 };
        btnAddProduto.Click += BtnAddProduto_Click;

        gbProduto.Controls.AddRange(new Control[] { lblNomeProduto, txtNomeProduto, lblCategoriaProduto, txtCategoriaProduto,
            lblPrecoProduto, txtPrecoProduto, lblQtdProduto, txtQtdProduto, btnAddProduto });

        dgvProdutos = new DataGridView { Top = 60, Left = 10, Width = 830, Height = 120, AutoGenerateColumns = true, ReadOnly = true };
        dgvProdutos.CellClick += DgvProdutos_CellClick;
        gbProduto.Controls.Add(dgvProdutos);

        lblTotalProdutos = new Label { Text = "Total estoque: 0", Top = 160, Left = 10, Width = 200 };
        gbProduto.Controls.Add(lblTotalProdutos);

        // ---------- SOFTWARE ----------
        GroupBox gbSoftware = new GroupBox
        {
            Text = "Softwares",
            Top = 220,
            Left = 10,
            Width = 860,
            Height = 150,
            Font = fontePadrao
        };
        this.Controls.Add(gbSoftware);

        Label lblNomeSoftware = new Label { Text = "Nome:", Top = 25, Left = 10, Width = 50 };
        txtNomeSoftware = new TextBox { Top = 22, Left = 70, Width = 150 };
        Label lblVersaoSoftware = new Label { Text = "Versão:", Top = 25, Left = 230, Width = 50 };
        txtVersaoSoftware = new TextBox { Top = 22, Left = 290, Width = 100 };
        Label lblPrecoSoftware = new Label { Text = "Preço:", Top = 25, Left = 400, Width = 40 };
        txtPrecoSoftware = new TextBox { Top = 22, Left = 450, Width = 80 };

        btnAddSoftware = new Button { Text = "Adicionar Software", Top = 20, Left = 550, Width = 150 };
        btnAddSoftware.Click += BtnAddSoftware_Click;

        gbSoftware.Controls.AddRange(new Control[] { lblNomeSoftware, txtNomeSoftware, lblVersaoSoftware, txtVersaoSoftware,
            lblPrecoSoftware, txtPrecoSoftware, btnAddSoftware });

        dgvSoftwares = new DataGridView { Top = 60, Left = 10, Width = 830, Height = 70, AutoGenerateColumns = true, ReadOnly = true };
        dgvSoftwares.CellClick += DgvSoftwares_CellClick;
        gbSoftware.Controls.Add(dgvSoftwares);

        lblTotalSoftwares = new Label { Text = "Total estoque: 0", Top = 130, Left = 10, Width = 200 };
        gbSoftware.Controls.Add(lblTotalSoftwares);

        // ---------- HARDWARE ----------
        GroupBox gbHardware = new GroupBox
        {
            Text = "Hardwares",
            Top = 380,
            Left = 10,
            Width = 860,
            Height = 200,
            Font = fontePadrao
        };
        this.Controls.Add(gbHardware);

        Label lblNomeHardware = new Label { Text = "Nome:", Top = 25, Left = 10, Width = 50 };
        txtNomeHardware = new TextBox { Top = 22, Left = 70, Width = 150 };
        Label lblTipoHardware = new Label { Text = "Tipo:", Top = 25, Left = 230, Width = 40 };
        txtTipoHardware = new TextBox { Top = 22, Left = 270, Width = 100 };
        Label lblFabricanteHardware = new Label { Text = "Fabricante:", Top = 25, Left = 380, Width = 70 };
        txtFabricanteHardware = new TextBox { Top = 22, Left = 460, Width = 120 };
        Label lblPrecoHardware = new Label { Text = "Preço:", Top = 25, Left = 590, Width = 40 };
        txtPrecoHardware = new TextBox { Top = 22, Left = 640, Width = 80 };
        Label lblQtdHardware = new Label { Text = "Qtd:", Top = 25, Left = 730, Width = 30 };
        txtQtdHardware = new TextBox { Top = 22, Left = 760, Width = 60 };

        btnAddHardware = new Button { Text = "Adicionar Hardware", Top = 20, Left = 720, Width = 120 };
        btnAddHardware.Click += BtnAddHardware_Click;

        gbHardware.Controls.AddRange(new Control[] { lblNomeHardware, txtNomeHardware, lblTipoHardware, txtTipoHardware,
            lblFabricanteHardware, txtFabricanteHardware, lblPrecoHardware, txtPrecoHardware, lblQtdHardware, txtQtdHardware, btnAddHardware });

        dgvHardwares = new DataGridView { Top = 60, Left = 10, Width = 830, Height = 120, AutoGenerateColumns = true, ReadOnly = true };
        dgvHardwares.CellClick += DgvHardwares_CellClick;
        gbHardware.Controls.Add(dgvHardwares);

        lblTotalHardwares = new Label { Text = "Total estoque: 0", Top = 160, Left = 10, Width = 200 };
        gbHardware.Controls.Add(lblTotalHardwares);
    }

    // ---------- EVENTOS ----------
    private void BtnAddProduto_Click(object? sender, EventArgs e)
    {
        if (decimal.TryParse(txtPrecoProduto.Text, out decimal preco) && int.TryParse(txtQtdProduto.Text, out int qtd))
        {
            Produto p = new Produto(txtNomeProduto.Text, txtCategoriaProduto.Text, preco, qtd);
            produtos.Add(p);
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;
            lblTotalProdutos.Text = $"Total estoque: {CalcularTotalProdutos():C}";
        }
        else
        {
            MessageBox.Show("Preço ou quantidade inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnAddSoftware_Click(object? sender, EventArgs e)
    {
        if (decimal.TryParse(txtPrecoSoftware.Text, out decimal preco))
        {
            Software s = new Software(txtNomeSoftware.Text, txtVersaoSoftware.Text, preco);
            softwares.Add(s);
            dgvSoftwares.DataSource = null;
            dgvSoftwares.DataSource = softwares;
            lblTotalSoftwares.Text = $"Total estoque: {CalcularTotalSoftwares():C}";
        }
        else
        {
            MessageBox.Show("Preço inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnAddHardware_Click(object? sender, EventArgs e)
    {
        if (decimal.TryParse(txtPrecoHardware.Text, out decimal preco) && int.TryParse(txtQtdHardware.Text, out int qtd))
        {
            Hardware h = new Hardware(txtNomeHardware.Text, txtTipoHardware.Text, txtFabricanteHardware.Text, preco, qtd);
            hardwares.Add(h);
            dgvHardwares.DataSource = null;
            dgvHardwares.DataSource = hardwares;
            lblTotalHardwares.Text = $"Total estoque: {CalcularTotalHardwares():C}";
        }
        else
        {
            MessageBox.Show("Preço ou quantidade inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // ---------- DEPRECIAÇÃO ----------
    private void DgvProdutos_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            Produto p = produtos[e.RowIndex];
            decimal depreciacao = p.Preco * 0.10m; // Exemplo 10% por depreciação
            decimal valorAtual = p.Preco - depreciacao;
            MessageBox.Show($"Produto: {p.Nome}\nPreço original: {p.Preco:C}\nDepreciação: {depreciacao:C}\nValor atual: {valorAtual:C}", "Depreciação");
        }
    }

    private void DgvSoftwares_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            Software s = softwares[e.RowIndex];
            decimal depreciacao = s.Preco * 0.20m; // Exemplo 20%
            decimal valorAtual = s.Preco - depreciacao;
            MessageBox.Show($"Software: {s.Nome}\nPreço original: {s.Preco:C}\nDepreciação: {depreciacao:C}\nValor atual: {valorAtual:C}", "Depreciação");
        }
    }

    private void DgvHardwares_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            Hardware h = hardwares[e.RowIndex];
            decimal depreciacao = h.Preco * 0.15m; // Exemplo 15%
            decimal valorAtual = h.Preco - depreciacao;
            MessageBox.Show($"Hardware: {h.Nome}\nPreço original: {h.Preco:C}\nDepreciação: {depreciacao:C}\nValor atual: {valorAtual:C}", "Depreciação");
        }
    }

    // ---------- MÉTODOS AUXILIARES ----------
    private decimal CalcularTotalProdutos()
    {
        decimal total = 0;
        foreach (var p in produtos) total += p.Preco * p.Quantidade;
        return total;
    }

    private decimal CalcularTotalSoftwares()
    {
        decimal total = 0;
        foreach (var s in softwares) total += s.Preco;
        return total;
    }

    private decimal CalcularTotalHardwares()
    {
        decimal total = 0;
        foreach (var h in hardwares) total += h.Preco * h.Quantidade;
        return total;
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new EstoqueForm());
    }
}

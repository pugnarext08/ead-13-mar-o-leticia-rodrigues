using System;
using System.Windows.Forms;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles(); // deixa os controles com o visual moderno
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new EstoqueForm()); // abre o formulário EstoqueForm
    }
}

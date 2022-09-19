namespace AvaliacaoLp3_Shopping.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public int Piso { get; set; }
    public string Nome { get; set; }
    public string Descrição { get; set; }
    public string Tipo { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, int piso, string nome, string descrição, string tipo, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descrição = descrição;
        Tipo = tipo;
        Email = email;
    }


}
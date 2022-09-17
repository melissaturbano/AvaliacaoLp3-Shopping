namespace AvaliacaoLp3_Shopping.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public string Piso { get; set; }
    public string Nome { get; set; }
    public string Descrição { get; set; }
    public bool Loja { get; set; }
    public string Email { get; set; }

    public LojaViewModel(int id, string piso, string nome, string descrição, bool loja, string email)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descrição = descrição;
        Loja = loja;
        Email = email;
    }


}
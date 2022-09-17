using Microsoft.AspNetCore.Mvc;
using AvaliacaoLp3_Shopping.ViewModels;

namespace AvaliacaoLp3_Shopping.Controllers;

public class ShoppingController : Controller 
{
    //add estudantes a lista, já que nao temos bdd 
    //private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>();
    private static List<LojaViewModel> lojas = 
        new List<LojaViewModel> {
            new LojaViewModel(1, "piso 01", "Sorvetinho gelado", "Sorvetinho gelado", false, "sorvet@email.com"),
            new LojaViewModel(2, "piso 02", "Lembranças Já", "Vem comprar sua lembrança", true, "lembranca@email.com"),
            new LojaViewModel(3, "piso 03", "Tênis Brasil", "Aqui você encontra tênis", true, "tenis@email.com")
        };

    public IActionResult ListaLojKio() //lista dos estudantes
    {
        return View(lojas);
    }

    public IActionResult Gerenciamento() //lista dos estudantes
    {
        return View(lojas);
    }

    public IActionResult Show(int id) //mostra detalhe dos estudantes
    {
        return View(lojas[id-1]);
    }

}
using Microsoft.AspNetCore.Mvc;
using AvaliacaoLp3_Shopping.Models;
using AvaliacaoLp3_Shopping.ViewModels;

namespace AvaliacaoLp3_Shopping.Controllers;

public class ShoppingController : Controller 
{
    //add lojas a lista, já que nao temos bdd 
    private static List<LojaViewModel> lojas = new List<LojaViewModel>();

    public IActionResult ListaLojKio() //lista do cliente
    {
        return View(lojas);
    }

    public IActionResult Gerenciamento() //lista do adm
    {
        return View(lojas);
    }

    //detalhe de cada loja
    public IActionResult Detalhe(int id){       

        //return View(lojas[id]);

        foreach(var loja in lojas)
        {
            if(loja.Id == id)
            {
               return View(loja);
            }
        }
        return View();
    }

    //cadastra loja
    public IActionResult Cadastro([FromForm] int id, [FromForm] string nome, [FromForm] string email, [FromForm] string tipo, [FromForm] string descricao, [FromForm] int piso){

        foreach (var loja in lojas)
        {
            if(nome == loja.Nome){
                ViewData["Nome"] = nome;
                return View();
            }
        }       

        LojaViewModel cadastro = new LojaViewModel(/*lojas.Count()*/id, piso, nome, descricao, tipo, email);
        lojas.Add(cadastro);

        return View("Cadastro");

    }


    //remove loja
    public IActionResult Remover(int id)
    {
        foreach(var loja in lojas)
        {
            if(loja.Id == id)
            {
               lojas.Remove(loja);
               ViewData ["Nome"] = loja.Nome;
               return View();
            }
        }

        return View();
    }


}
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

/*alterações feitas depois da consulta em aula com o professor corrigindo as falhas de validação*/
    //cadastra loja
    public IActionResult Cadastro([FromForm] int id, [FromForm] string nome, [FromForm] string email, [FromForm] string tipo, [FromForm] string descricao, [FromForm] int piso){

        foreach (var loja in lojas)
        {

            if(loja.Nome.Equals(nome))
            {
                ViewData ["Nome"] = loja.Nome;
                return View("Mensagem");
            }
        }

        if(id != 0)
        { 
            lojas.Add(new LojaViewModel(id, piso, nome, descricao, tipo, email));
        } 

        return View() ;

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
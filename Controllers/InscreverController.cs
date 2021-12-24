using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using area51.Models;

namespace area51.Controllers
{

    public class InscreverController : Controller
    {

public IActionResult Editar (int Id){
InscreverDB DB = new InscreverDB();
Inscrever userLocalizado = DB.BuscarPorId(Id);
return View(userLocalizado);
}
[HttpPost]

public IActionResult Editar(Inscrever user){

InscreverDB DB = new InscreverDB();
DB.Alterar(user);
 return RedirectToAction("Lista", "Inscrever");


}






public IActionResult Remover(int Id){


    InscreverDB DB = new InscreverDB();
    Inscrever userLocalizado = DB.BuscarPorId(Id);
    DB.Excluir(userLocalizado);
    return RedirectToAction("Lista", "Inscrever");
}



        
public IActionResult Lista(){

InscreverDB DB = new InscreverDB();
List<Inscrever> listagem = DB.Listar();
return View(listagem);
}






public IActionResult Cadastro(){
    return View();
}

[HttpPost]

public IActionResult Cadastro(Inscrever user){

InscreverDB DB = new InscreverDB();
DB.Inserir(user);
ViewBag.Mensagem = "Matrícula feita com sucesso";
return View();
}




    }
}
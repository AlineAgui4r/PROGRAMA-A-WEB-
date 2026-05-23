using Microsoft.AspNetCore.Mvc;
public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Aline";
        ViewBag.Cusro = "Tecnico em Analise de Desenvolvimento de Sistema";
        ViewBag.Semestre = "Primeiro Semestre";
        return View();
    }

     
} 

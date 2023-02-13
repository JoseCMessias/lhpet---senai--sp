using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "ArthurA.Ferreira@gmail.com", "Bob");
        Cliente cliente2 = new Cliente(02, "Jose messias", "888.555.999-44", "josemessias@gmail.com", "Madruga");
        Cliente cliente3 = new Cliente(03, "Fernanda lopes", "111.222.333-44", "fernands@gmail.com", "Madu");
        Cliente cliente4 = new Cliente(04, "Lucas otaco", "888-.222.666-54", "lucas@gmail.com", "Trovão");
        Cliente cliente5 = new Cliente(05, "Jose abraão", "555.333.777-98", "abraao@gmail.com", "Ninguem");

        // Lista de Clientes com atrinuição deles
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "c# PRT S/A", "14.182.102/0001-80", "c-sharp@pet.org.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Gatos pets", "13.173.113/0002-80", "pets@pet.org.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "model dogs", "12.184.124/0003-90", "modeldogs@pet.org.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "petshop friend", "11.185.103/0004-91", "shopfriend@pet.org.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "gatoshop", "10.186.104/0005-92", "gatosshopp@pet.org.br");

         // Lista de Fornecedores com atrinuição deles
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

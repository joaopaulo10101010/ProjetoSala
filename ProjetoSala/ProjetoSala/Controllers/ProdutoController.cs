﻿using Microsoft.AspNetCore.Mvc;

namespace ProjetoSala.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

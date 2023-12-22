﻿using CadastroFilmes.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFilmes.Web.Controllers;

public class FilmeController : Controller
{
    private List<Filme> filmes = new List<Filme>();

    public FilmeController()
    {
        CarregarListas();
    }

    public IActionResult Index()
    {
        return View(filmes);
    }

    public IActionResult Details(int id)
    {
        Filme filmepesquisado = filmes.FirstOrDefault(p => p.Id.Equals(id));
        return View(filmepesquisado);
    }

    private void CarregarListas()
    {
        Filme filme = new Filme(1, "filme1", "drama1");
        Filme filme1 = new Filme(2, "filme2", "drama2");
        Filme filme2 = new Filme(3, "filme3", "drama3");
        Filme filme3 = new Filme(4, "filme4", "drama4");

        filmes.Add(filme);
        filmes.Add(filme1);
        filmes.Add(filme2);
        filmes.Add(filme3);
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexClient.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq; 

namespace PokemonsController.Controllers;

public class PokemonsController : Controller
{
    private readonly PokedexContext _db;
    
    public PokemonsController(PokedexContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
        List<Pokemon> model = _db.Pokemons.ToList();
        return View(model);
        
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PokedexClient.Models;

namespace PokedexClient.Controllers;

public class HomeController : Controller
{
    private readonly PokedexContext _db;
    
    public HomeController(PokedexContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
        
    }

}

// Build FAILED.

// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Models/PokemonDataSeeder.cs(11,31): error CS0103: The name 'Path' does not exist in the current context [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Models/PokemonDataSeeder.cs(14,33): error CS0246: The type or namespace name 'StreamReader' could not be found (are you missing a using directive or an assembly reference?) [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Models/PokemonDataSeeder.cs(15,48): error CS1503: Argument 2: cannot convert from 'CsvHelper.Configuration.CsvConfiguration' to 'System.Globalization.CultureInfo' [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Models/PokemonDataSeeder.cs(17,46): error CS0246: The type or namespace name 'PokemonDto' could not be found (are you missing a using directive or an assembly reference?) [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Models/PokemonDataSeeder.cs(17,60): error CS1061: 'IEnumerable<PokemonDto>' does not contain a definition for 'ToList' and no accessible extension method 'ToList' accepting a first argument of type 'IEnumerable<PokemonDto>' could be found (are you missing a using directive or an assembly reference?) [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
// /Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/Program.cs(40,25): error CS1061: 'DbSet<Pokemon>' does not contain a definition for 'Any' and no accessible extension method 'Any' accepting a first argument of type 'DbSet<Pokemon>' could be found (are you missing a using directive or an assembly reference?) [/Users/shankaronmohamed/Desktop/epicodus/c#/Pokedex.Solution/PokedexClient/PokedexClient.csproj]
//     0 Warning(s)
//     6 Error(s)

// Time Elapsed 00:00:01.12
// (base) shankaronmohamed@Shankarons-MBP PokedexClient % 

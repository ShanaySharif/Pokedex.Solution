using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PokedexClient.Models;

public class PokedexContext : DbContext
{
public DbSet<Pokemon> Pokemons { get; set; }
public PokedexContext(DbContextOptions options) : base(options) { }
}





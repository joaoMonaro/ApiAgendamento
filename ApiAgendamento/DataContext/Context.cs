using ApiAgendamento.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendamento.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<ClienteModel> ClienteModels { get; set; }
    public DbSet<PrestadorModel> PrestadorModels { get; set; }
    public DbSet<UsuarioModel> UsuarioModel { get; set; }
}

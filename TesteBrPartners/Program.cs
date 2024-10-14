using Microsoft.EntityFrameworkCore;
using TesteBrPartners.Application.Interfaces;
using TesteBrPartners.Application.Services;
using TesteBrPartners.Infra.Data;
using TesteBrPartners.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext com a string de conexão
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicione outros serviços necessários
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configuração do pipeline da aplicação
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

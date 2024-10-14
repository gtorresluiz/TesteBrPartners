using Microsoft.EntityFrameworkCore;
using TesteBrPartners.Application.Interfaces;
using TesteBrPartners.Application.Services;
using TesteBrPartners.Infra.Data;
using TesteBrPartners.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do DbContext com a string de conex�o
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Adicione outros servi�os necess�rios
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configura��o do pipeline da aplica��o
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

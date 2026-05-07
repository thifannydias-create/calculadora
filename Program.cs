var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Ativa arquivos HTML
app.UseDefaultFiles();
app.UseStaticFiles();

// Rota simples (API)
app.MapGet("/api/ola", (string nome) =>

{
    return $"Olá, {nome}! Bem-vindo ao C# "
    ;

});

app.Run();
using IntegracaoBrasilApi.Interfaces;
using IntegracaoBrasilApi.Mapping;
using IntegracaoBrasilApi.Rest;
using IntegracaoBrasilApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IBrasilApi, BrasilApiRest>();
builder.Services.AddSingleton<IBancoService, BancoService>();
builder.Services.AddSingleton<ICambioService, CambioService>();
builder.Services.AddSingleton<ICepService, CepService>();
builder.Services.AddSingleton<ICnpjService, CnpjService>();


builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<BancoMapping>();
    cfg.AddProfile<CambioMapping>();
    cfg.AddProfile<CepMapping>();
    cfg.AddProfile<CnpjMapping>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

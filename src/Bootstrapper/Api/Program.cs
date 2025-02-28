

var builder = WebApplication.CreateBuilder(args);  //The builder is used as the foundation for configuring your application's services before the app starts.

// Add services to the container

builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

//Configure the HTTP request pipeline

app
    .UseBasketModule()
    .UseOrderingModule()
    .UseCatalogModule();


app.Run();

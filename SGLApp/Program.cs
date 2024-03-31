using SGLApp.Components;
using SGLApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using SGLApp.Infrastructure.Repositories;
using SGLApp.Application.Interfaces;
using SGLApp.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<SGLAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SGLAppConnection"));
});
builder.Services.AddScoped<ICreditRepository, CreditRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<IWinningTicketRepository, WinningTicketRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
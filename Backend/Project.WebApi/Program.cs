using MediatR;
using Microsoft.OpenApi.Models;
using Project.BusinessLayer.Resolvers.Services.AutoMapper;
using Project.BusinessLayer.Resolvers.Services.Context;
using Project.BusinessLayer.Resolvers.Services.Identity;
using Project.BusinessLayer.Resolvers.Services.Mediator;
using Project.BusinessLayer.Resolvers.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.ContextResolver();
builder.Services.IdentityResolver();
builder.Services.RepositoryResolver();
builder.Services.MapperResolver();
builder.Services.AddControllers();
builder.Services.AddMediatorService(builder.Configuration);
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("PortfolioApi", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PortfolioApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PortfolioApi v1"));
}

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors("PortfolioApi");
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();

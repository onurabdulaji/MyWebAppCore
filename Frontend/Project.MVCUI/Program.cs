using Project.BusinessLayer.Resolvers.Services.AutoMapper;
using Project.BusinessLayer.Resolvers.Services.Context;
using Project.BusinessLayer.Resolvers.Services.Identity;
using Project.BusinessLayer.Resolvers.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.ContextResolver();
builder.Services.IdentityResolver();
builder.Services.RepositoryResolver();
builder.Services.MapperResolver();
builder.Services.AddControllers();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

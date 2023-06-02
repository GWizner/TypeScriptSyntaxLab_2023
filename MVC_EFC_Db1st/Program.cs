/*First, create a SQL database. It can be as simple as you'd like.
 * Install the Nuget Package: Microsoft.EntityFrameworkCore.Design
 *
 * EXAMPLE CLI scaoffolding command:
 *dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook" Microsoft.EntityFrameworkCore.SqlServer
 * EXAMPLE Package Manager Console command:
 *Scaffold-DbContext "Server=.\SQLEXPRESS;Database=<<Database>>; Integrated Security=True; Encrypt=false" Microsoft.EntityFrameworkCore.SqlServer
 *
 *Connection string = Tools - Connect To Database (it may ask you to choose a connection type, if it does choose SQL server) 
- Enter server name (usually something like .\SQLEXPRESS) 
- choose target database in dropdown 
- click Advanced - copy connection string and add Encrypt=false to the end
 */

using MVC_EFC_Db1st;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DessertDbContext>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

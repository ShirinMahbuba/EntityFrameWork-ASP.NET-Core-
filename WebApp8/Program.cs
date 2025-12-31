var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "amardesh",
    pattern: "{year}/{month}/{day}",
  defaults: new { controller = "News", ation = "Amardesh" });

app.MapControllerRoute(
    name: "artical",
    pattern: "news/{year}/{month}/{day}/{pageno=1}/{aid?}",
 defaults:new {controller="News",ation="Amadersomoy"});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

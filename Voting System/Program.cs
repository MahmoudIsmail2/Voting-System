using Bl;
using Domains;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SystemVotingContext>();

builder.Services.AddScoped<IClsImgs, ClsImgs>();
builder.Services.AddScoped<IClsVoteLists, ClsVoteLists>();
builder.Services.AddScoped<IClsUsers,ClsUsers>();
builder.Services.AddScoped<IClsVotes, ClsVotes>();

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

app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => 
{

   
    endpoints.MapControllerRoute(
    name:"Default",
    pattern:"{controller=Home}/{action=index}/{id?}" );

    endpoints.MapControllerRoute(
   name: "Admin",
   pattern: "{area=exist}/{controller=Home}/{action=List}/{id?}");


}); 

app.Run();

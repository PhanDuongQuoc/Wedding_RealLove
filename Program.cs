var builder = WebApplication.CreateBuilder(args);

// Thêm Runtime Compilation chỉ trong môi trường phát triển
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddControllersWithViews()
            .AddRazorRuntimeCompilation();
}
else
{
    builder.Services.AddControllersWithViews();
}

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = context =>
    {
        // Thiết lập thời gian cache là 0 để không lưu cache lâu
        context.Context.Response.Headers["Cache-Control"] = "no-store, no-cache, must-revalidate";
        context.Context.Response.Headers["Expires"] = "0";
    }
});
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DashBoard}/{action=Index}/{id?}");
app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Album}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // HSTS is disabled so the app can be served over plain HTTP if desired.
    // The default HSTS value is 30 days. You may want to enable this for production scenarios.
    // app.UseHsts();
}

// Do not force HTTPS redirection so the site can be accessed using HTTP.
// app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();

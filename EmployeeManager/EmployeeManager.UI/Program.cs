using EmployeeManager.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// register HttpClient for API
builder.Services.AddHttpClient<IEmployeeApiService, EmployeeApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5084/");
});

builder.Services.AddHttpClient<IDepartmentApiService, DepartmentApiService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5084/"); // Your API URL
});


var app = builder.Build();

// pipeline
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

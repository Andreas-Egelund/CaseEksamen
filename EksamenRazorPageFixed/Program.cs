using CaseLibrary.Services;
using CaseLibrary.Servicses;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();


builder.Services.AddSingleton<UserRepository>();
builder.Services.AddSingleton<BoatRepository>();
builder.Services.AddSingleton<BookingRepository>();
builder.Services.AddSingleton<EventRepository>();
builder.Services.AddSingleton<BlogRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

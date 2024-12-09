var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers(); // Remove this line
builder.Services.AddControllersWithViews(); // Add this line
builder.Services.AddRazorPages(); // Add this line

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage(); // Add this line
    app.UseWebAssemblyDebugging(); // Add this line
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles(); // Add this line
app.UseStaticFiles(); // Add this line

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages(); // Add this line
app.MapFallbackToFile("index.html"); // Add this line

app.Run();
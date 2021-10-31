var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<MyActor>();
builder.Services.AddActors(options =>
{
    options.Actors.RegisterActor<MyActor>();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapActorsHandlers();
});

app.Run();

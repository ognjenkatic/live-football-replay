using LiveFootball.Application;
using LiveFootball.Application.Competitions;
using LiveFootball.Application.Matches;
using LiveFootball.Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<OpenDataConfig>(builder.Configuration.GetRequiredSection("OpenData"));

builder.Services.AddScoped<CompetitionService>();
builder.Services.AddScoped<MatchService>();
builder.Services.AddSingleton<IndexerService>();
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(
    x =>
        x.AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true) // allow any origin
            .AllowCredentials()
);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<MatchEventsHub>("/MatchHub");

app.MapFallbackToFile("/index.html");

var indexer = app.Services.GetRequiredService<IndexerService>();
indexer.IndexMatches();
app.Run();

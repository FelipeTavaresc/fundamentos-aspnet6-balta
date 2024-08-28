using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>();
//builder.Services.AddTransient() Sempre cria uma nova intância
//builder.Services.AddScoped() Dura o tempo da requisição
//builder.Services.AddSingleton()  Uma instância para toda aplicação

var app = builder.Build();
app.MapControllers();

app.Run();

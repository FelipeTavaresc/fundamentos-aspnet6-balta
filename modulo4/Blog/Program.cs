using Blog.Data;
using Blog.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient<TokenService>();
//builder.Services.AddTransient() Sempre cria uma nova int�ncia
//builder.Services.AddScoped() Dura o tempo da requisi��o
//builder.Services.AddSingleton()  Uma inst�ncia para toda aplica��o

var app = builder.Build();
app.MapControllers();

app.Run();

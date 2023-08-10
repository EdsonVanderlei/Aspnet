using Commerce.Configuration;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ResolveDependencyInjection();
builder.Services.AddGeneralConfiguration(builder.Configuration);
builder.Services.AddIdentityConfiguration(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.UseAuthentication();
app.UseHttpsRedirection();



app.MapControllers();

app.Run();

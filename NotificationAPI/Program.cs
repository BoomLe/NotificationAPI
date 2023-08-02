using CorePush.Apple;
using CorePush.Google;
using NotificationAPI.Services.IServices;
using NotificationAPI.Services;
using Microsoft.Extensions.Configuration;
using NotificationAPI.Models;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddHttpClient<FcmSender>();
builder.Services.AddHttpClient<ApnSender>();

var appSettingsSection =builder.Configuration.GetSection("FcmNotification");
builder.Services.Configure<FcmNotificationSetting>(appSettingsSection);

builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc(name: "V1", new OpenApiInfo { Title = "My Notification API", Version = "V1" });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint(url: "/swagger/V1/swagger.json", name: "My Notification API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

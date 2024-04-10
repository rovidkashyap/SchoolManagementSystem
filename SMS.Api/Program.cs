using MediatR;
using Microsoft.EntityFrameworkCore;
using SMS.Application.Features.Students.Handlers.CommandHandlers.AcademicsHandlers;
using SMS.Application.Features.Students.Handlers.CommandHandlers.StudentPersonalHandlers;
using SMS.Core.Repository.Base;
using SMS.Core.Repository.Academics;
using SMS.Infrastructure.Repository.Academics;
using SMS.Core.Services;
using SMS.Infrastructure.Context;
using SMS.Infrastructure.Repository.Base;
using System.Reflection;
using SMS.Core.Repository.Student;
using SMS.Infrastructure.Repository.Student;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(CreateClassCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateSectionCommandHandler).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(CreateStudentPersonalCommandHandler).GetTypeInfo().Assembly);

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<ISectionRepository, SectionRepository>();
builder.Services.AddScoped<IStudentPersonalRepository, StudentPersonalRepository>();
builder.Services.AddTransient<IDateTimeService, DateTimeService>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("smsConnectionString"));
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
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

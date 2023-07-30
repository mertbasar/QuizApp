using QuizApp.Business.AnswerManager;
using QuizApp.Business.CategoryManagers;
using QuizApp.Business.QuestionManagers;
using QuizApp.Business.QuizManagers;
using QuizApp.Business.Validators.Generics;
using QuizApp.Data;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

Trace.Listeners.Add(new TextWriterTraceListener("error-logs.txt"));
Trace.AutoFlush = true;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ICategoryService, CategoryServices>();
builder.Services.AddTransient<IQuizService, QuizService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IAnswerService, AnswerService>();
builder.Services.AddTransient<AnswerValidator>();
builder.Services.AddTransient<CategoryValidator>();
builder.Services.AddTransient<QuizValidator>();
builder.Services.AddTransient<QuestionValidator>();
builder.Services.AddDbContext<QuizDbContext>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//0-目標：設定WebAPI的路由 (Route Pattern)-唯一進入點

using WebAPI_Practice;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers(); //新增所有Controller到系統
builder.Services.AddControllers().AddJsonOptions(_ => {}); //允許使用Json格式
builder.Services.AddTransient<CheckService>(); //每次呼叫都會建立一個新的CheckService
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapControllers();   //讓所有Controller可以被呼叫 允許使用[Route]或[HttpGet]等標籤-API用
//app.MapDefaultControllerRoute(); //預設路由-不另外定義[Route]或[HttpGet]-MVC用
/*app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"); 
);*/ //預設路由-不另外定義[Route]或[HttpGet]-MVC用
/*app.MapControllerRoute(
    "apiRoute", "api/{controller}/{action}}"); //自訂路由
)*/ //API客製化
/*
var services = builder.Services;
services.AddControllersWithViews();
services.AddTransient<UserService>();
services.AddTransient<IUSerService, UserService>();
services.AddTransient<UserRepository>(x => new UserRepository("host=localhost;user=root;password=1234"));
*/
/*
builder.Host.ConfigureServices((context, services) =>
{
    services.AddTransient<UserService>();
    services.AddTransient<IUserService, UserService>(); //當有人要用到IUserService時，會自動建立UserService
    services.AddTransient<UserRepository>(x => new UserRepository("host=localhost;user=root;password=1234"));
});*/
app.Run();
using WebAPI_Practice;
//0-目標：設定WebAPI的路由 (Route Pattern)-唯一進入點
var builder = WebApplication.CreateBuilder(args);
//a.新增所有Controller到系統
//builder.Services.AddControllers(); 
builder.Services.AddControllers().AddJsonOptions(_ => {}); //AddJsonOptions允許使用Json格式
//b.1-每次呼叫都會建立一個新的CheckService
builder.Services.AddTransient<CheckService>();
//b.2-同一次請求只會建立一個CheckService
//builder.Services.AddScoped<CheckService>();
//b.3-整個應用程式只會建立第一次建立的CheckService
//builder.Services.AddSingleton<CheckService>(); 
//c1.設定Swagger，先在NuGet安裝Swashbuckle.AspNetCore
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "WebAPI_Practice", Version = "v1" });
});
var app = builder.Build();
app.MapGet("/", () => "Hello World!"); //設定根目錄的回應
//d.1-讓所有Controller可以被呼叫 允許使用[Route]或[HttpGet]等標籤-API用
app.MapControllers();   
//d.2-預設路由-不另外定義[Route]或[HttpGet]-MVC用
//app.MapDefaultControllerRoute(); 
//d.3-預設路由-不另外定義[Route]或[HttpGet]-MVC用
/*app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}/{id?}"); 
);*/ 
//d.4-自訂路由 API客製化
/*app.MapControllerRoute(
    "apiRoute", "api/{controller}/{action}}");
)*/
/* 補充參考:課程範例設定DI的方式1
var services = builder.Services;
services.AddControllersWithViews();
services.AddTransient<UserService>();
services.AddTransient<IUSerService, UserService>();
services.AddTransient<UserRepository>(x => new UserRepository("host=localhost;user=root;password=1234"));
*/
/* 補充參考:課程範例設定DI的方式2
builder.Host.ConfigureServices((context, services) =>
{
    services.AddTransient<UserService>();
    services.AddTransient<IUserService, UserService>(); //當有人要用到IUserService時，會自動建立UserService
    services.AddTransient<UserRepository>(x => new UserRepository("host=localhost;user=root;password=1234"));
});*/

//c2.設定Swagger，可在/swagger/v1/swagger.json查看錯誤訊息，所有Action必須加上[HttpGet]或[HttpPost]
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI_Practice v1"));

app.Run();
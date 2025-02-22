//0-目標：設定WebAPI的路由 (Route Pattern)-唯一進入點
var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers(); //新增所有Controller到系統
builder.Services.AddControllers().AddJsonOptions(_ => {}); //允許使用Json格式
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

app.Run();
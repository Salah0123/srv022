//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();




using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string[] s3_facts =
{
    "Scale storage resources to meet fluctuating needs with 99.999999999% (11 9s) of data durability.",
    "Store data across Amazon S3 storage classes to reduce costs without upfront investment or hardware refresh cycles.",
    "Protect your data with unmatched security, compliance, and audit capabilities.",
    "Easily manage data at any scale with robust access controls, flexible replication tools, and organization-wide visibility.",
    "Run big data analytics, artificial intelligence (AI), machine learning (ML), and high performance computing (HPC) applications.",
    "Meet Recovery Time Objectives (RTO), Recovery Point Objectives (RPO), and compliance requirements with S3's robust replication features."
};

var rnd = new Random();

app.MapGet("/", () =>
{
    int i = rnd.Next(0, s3_facts.Length);
    string msg = $"{DateTime.Now:T} - {s3_facts[i]}";
    return Results.Text(msg, "text/plain");
});

app.Run("http://0.0.0.0:8002");

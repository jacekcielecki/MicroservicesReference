using MicroservicesReference.Products.Core;
using MicroservicesReference.Users.Core;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

// Application Insights isn't enabled by default. See https://aka.ms/AAt8mw4.
// builder.Services
//     .AddApplicationInsightsTelemetryWorkerService()
//     .ConfigureFunctionsApplicationInsights();

Environment.SetEnvironmentVariable("MicroservicesReference_Db", "Server=(localdb)\\MSSQLLocalDB;Database=MicroservicesReference_Users;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true;");

builder.Services.RegisterUsersModule();
builder.Services.RegisterProductsModule();

builder.Build().Run();

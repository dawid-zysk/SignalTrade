var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CryptoService>("crypto");

builder.Build().Run();

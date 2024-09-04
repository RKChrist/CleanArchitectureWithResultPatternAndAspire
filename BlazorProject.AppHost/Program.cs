var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorProject>("blazorproject");

builder.AddProject<Projects.BlazorProject_WebApi>("blazorproject-webapi");

builder.Build().Run();

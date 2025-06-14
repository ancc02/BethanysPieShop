var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BethanysPieShop>("bethanyspieshop");

builder.Build().Run();

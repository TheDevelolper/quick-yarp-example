var builder = DistributedApplication.CreateBuilder(args);

var weather1 = builder.AddProject<Projects.weather1>("weather1");
var weather2 = builder.AddProject<Projects.weather2>("weather2");
var yarp = builder.AddProject<Projects.yarp>("yarp");

builder.Build().Run();

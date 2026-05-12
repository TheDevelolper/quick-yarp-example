var builder = DistributedApplication.CreateBuilder(args);

// create 10 instances of the example-api project, each with a different INSTANCE ID environment variable
var basePort = 7700;

for (int i = 0; i < 10; i++)
{
    var publicPort = basePort + i;

    builder
        .AddProject<Projects.example_api>(
            $"api-instance-{i}",
            configure: project =>
            {
                project.ExcludeLaunchProfile = true;
            })
        .WithEnvironment("INSTANCE_ID", i.ToString())
        .WithHttpsEndpoint(targetPort: publicPort);
}

var yarp = builder.AddProject<Projects.yarp>("yarp");

builder.Build().Run();

namespace backend.Configurations;

public static class EnvConfig
{
    public static void LoadEnv(this WebApplicationBuilder builder)
    {
        DotNetEnv.Env.Load(Path.Combine(Directory.GetCurrentDirectory(), ".env"));
        builder.Configuration.AddEnvironmentVariables();
    }
}

using Microsoft.Extensions.Configuration;

namespace TestProject.Helpers
{
    internal static class ConfigurationManager
    {
        public static ConfigSettings Config;

        public static string GetPath()
        {
            return Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Setting/ConfigurationFile.json";
        }
        public static ConfigSettings GetConfigvalue()
        {
            Config = new ConfigSettings();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(GetPath());
            IConfigurationRoot configurationRoot = builder.Build();
            configurationRoot.Bind(Config);
            return Config;
        }
    }
}

using System;
namespace Configuration
{
    public static class Constants
    {
        public static string BASE_YTS_URL = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_BASE_YTS_URL")) ? "https://yts.mx/api/v2/" : Environment.GetEnvironmentVariable("ASPNETCORE_BASE_YTS_URL");

        public static string ENVIRONMENT = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    }
}
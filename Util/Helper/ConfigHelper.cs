using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Util
{
    /// <summary>
    /// 配置文件帮助类
    /// </summary>
    public static class ConfigHelper
    {
        static ConfigHelper()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                  .Add(new JsonConfigurationSource { Path = "appsettings.json" });

            Config = builder.Build();
        }

        private static IConfiguration Config { get; }

        /// <summary>
        /// 从AppSettings获取key的值
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            return Config[key];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MikaSafePass.Entity;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace MikaSafePass.Helper
{
    public static class ConfigHelper
    {
        // Path.combine permet de combiner 2 chemin %Appdata% + nom du dossier
        private static readonly string configDirPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MikaSafePass");
        private static readonly string configFileName = "MikaSafePassConfig.json";

        private static readonly string configFilePath = Path.Combine(configDirPath, configFileName);

        public static void SaveConfig(Config config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions
            {
                WriteIndented= true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
                Directory.CreateDirectory(configDirPath);

            File.WriteAllText(configFilePath, json);
        }
    }
}

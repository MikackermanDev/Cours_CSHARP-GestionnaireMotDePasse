using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MikaSafePass.Entity;

namespace MikaSafePass.Helper
{
    public static class DatabaseHelper
    {
        public static void SauvegardeDatabase(string path, DataBase database)
        {
            var nomFichier = Guid.NewGuid().ToString() + " tmp";
            var tempFichierPath = Path.Combine(Path.GetTempPath(), nomFichier);

            File.WriteAllText(tempFichierPath, JsonSerializer.Serialize(database));

            Security.EncryptFile(database.Hash, tempFichierPath, path);

            File.Delete(tempFichierPath);
        }
    }
}

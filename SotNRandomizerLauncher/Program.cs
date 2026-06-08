using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SotNRandomizerLauncher
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EnsureUserSettingsFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        // App.config delega <appSettings> a este archivo externo via configSource.
        // Lo creamos vacío si no existe para evitar ConfigurationErrorsException en el primer arranque
        // y para que los settings que guarda el usuario en runtime no se pisen al recompilar.
        static void EnsureUserSettingsFile()
        {
            string userSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "user.settings.config");
            if (File.Exists(userSettingsPath)) return;

            const string emptyAppSettings = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<appSettings>\r\n</appSettings>";
            File.WriteAllText(userSettingsPath, emptyAppSettings);
        }
    }
}

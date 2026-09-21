using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SilenceRemoverApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string htmlFile = Path.Combine(baseDir, "silence remover.html");
                if (!File.Exists(htmlFile))
                {
                    string fallbackPath = @"C:\Users\lucas\Desktop\Programas VSC\Silence Remover\silence remover.html";
                    if (File.Exists(fallbackPath))
                    {
                        htmlFile = fallbackPath;
                    }
                    else
                    {
                        MessageBox.Show(
                            "Não foi possível encontrar o arquivo silence remover.html.\nCertifique-se de que ele está na mesma pasta do executável.",
                            "Silence Remover Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }

                string[] browserCandidates = new string[]
                {
                    @"C:\Program Files\Google\Chrome\Application\chrome.exe",
                    @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                    @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe",
                    @"C:\Program Files\Microsoft\Edge\Application\msedge.exe",
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Google\Chrome\Application\chrome.exe"),
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Microsoft\Edge\Application\msedge.exe")
                };

                string browserPath = null;
                foreach (string candidate in browserCandidates)
                {
                    if (File.Exists(candidate))
                    {
                        browserPath = candidate;
                        break;
                    }
                }

                string fileUrl = "file:///" + htmlFile.Replace('\\', '/');
                string profileDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SilenceRemoverAppProfile");

                if (browserPath != null)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = browserPath,
                        Arguments = string.Format("--allow-file-access-from-files --app=\"{0}\" --user-data-dir=\"{1}\" --app-id=\"SilenceRemoverApp\"", fileUrl, profileDir),
                        UseShellExecute = false
                    });
                }
                else
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = htmlFile,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar o Silence Remover: " + ex.Message, "Silence Remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


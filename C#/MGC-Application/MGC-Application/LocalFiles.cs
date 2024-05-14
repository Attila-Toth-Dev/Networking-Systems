using System.Diagnostics;
using System.IO.Compression;

namespace MGC_Application;

public static class LocalFiles
{
    public static void ExecuteGame(string _game, string _pathfile)
    {
        if(IsGameInstalled(_game, _pathfile))
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = $"{_pathfile}/{_game}/{_game}/{_game}.exe";
            process.Start();
        }
    }

    public static void InstallGame(string _game, string _pathfile)
    {
        if(NetworkTools.CheckValidFTP(NetworkTools.ServerIP, NetworkTools.Username, NetworkTools.Password))
        {
            if (!IsGameInstalled(_game, _pathfile))
            {
                DialogResult dialogResult = MessageBox.Show($"Would you like to install {_game}?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(NetworkTools.DownloadGameFromFtp(_game, _pathfile))
                    {
                        Thread.Sleep(5000);

                        if (ExtractDownloadedGame(_game, _pathfile))
                            MessageBox.Show($"{_game} has been successfully installed");
                        else
                            MessageBox.Show($"Error installing {_game}.\nPlease try again.");
                    }
                }
            }
        }
    }

    public static void UninstallGame(string _game, string _pathfile)
    {
        if(IsGameInstalled(_game, _pathfile))
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you would like to uninstall {_game}?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string dir = $"{_pathfile}/{_game}";

                File.Delete($"{_pathfile}/{_game}.zip");
                Directory.Delete(dir, true);
                MessageBox.Show($"{_game} has been successfully uninstalled.");
            }
        }
    }

    public static bool IsGameInstalled(string _game, string _pathfile)
    {
        if (Directory.Exists($"{_pathfile}/{_game}"))
        {
            MessageBox.Show($"{_game} game folder already exists.\nStatus: Installed");
            return true;
        }
        else
        {
            MessageBox.Show($"{_game} game files do not exist.\nStatus: Not Installed");
            return false;
        }
    }

    private static bool ExtractDownloadedGame(string _game, string _pathfile)
    {
        string start = $"{_pathfile}/{_game}.zip";
        string end = $"{_pathfile}/{_game}";

        ZipFile.ExtractToDirectory(start, end);

        return true;
    }
}

using System.Diagnostics;

namespace MGC_Application;

public static class LocalFiles
{
    public static void ExecuteGame(string _game, string _pathfile)
    {
        if(IsGameInstalled(_game, _pathfile))
        {
            MessageBox.Show($"Starting up {_game}.\nHave fun!!");
         
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
                    NetworkTools.DownloadGameFromFtp(_game, _pathfile);

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

    private static void ExtractDownloadedGame(string _game, string _pathfile)
    {

    }
}

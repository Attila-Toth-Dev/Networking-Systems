using System.Diagnostics;
using System.IO.Compression;

namespace MGC_Application;

public static class LocalFiles
{
    /// <summary>Function for running the exe file of installed game.</summary>
    /// <param name="_game">The game to run the .exe of.</param>
    /// <param name="_pathfile">The pathfile of said game.</param>
    public static void ExecuteGame(string _game, string _pathfile)
    {
        if (IsGameInstalled(_game, _pathfile))
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = $"{_pathfile}/{_game}/{_game}.exe";
            process.Start();

            DebugLogger.WriteLog($"{_game} Status: RUNNING (Line 20)");
            MessageBox.Show($"Launching {_game}.exe");
        }
        else
        {
            DebugLogger.WriteLog($"{_game} Status: MISSING FILES (Line 25)");
            MessageBox.Show($"Cannot run {_game}.exe.\nGame files appear to be missing.");
        }
    }

    /// <summary>Function for downloading and installing the game files.</summary>
    /// <param name="_game">The game to download and install.</param>
    /// <param name="_pathfile">The path of which to install the game in.</param>
    public static bool DownloadGame(string _game, string _pathfile)
    {
        NetworkTools.DownloadGameFromFtp(_game, _pathfile);

        DebugLogger.WriteLog($"{_game} Status: DOWNLOADED (Line 43)");
        MessageBox.Show($"Downloaded {_game}");

        return true;
    }

    /// <summary>Function for extracting newly downloaded files from FTP server.</summary>
    /// <param name="_game">The game of which to extract files from.</param>
    /// <param name="_pathfile">The pathfile of said game zip.</param>
    public static bool ExtractInstallGame(string _game, string _pathfile)
    {
        string start = $"{_pathfile}/{_game}.zip";
        string end = $"{_pathfile}/{_game}";

        ZipFile.ExtractToDirectory(start, end);
        Thread.Sleep(1000);
        File.Delete(start);

        DebugLogger.WriteLog($"{_game} Status: DOWNLOADED|EXTRACTING (Line 110)");
        return true;
    }

    /// <summary>Function for uninstalling game</summary>
    /// <param name="_game">The game that will be uninstalled.</param>
    /// <param name="_pathfile">The path of game.</param>
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

                DebugLogger.WriteLog($"{_game} Status: UNINSTALLED AND REMOVED (Line 69)");
                MessageBox.Show($"Uninstalled {_game} and corresponding files.");
            }
        }
        else
        {
            DebugLogger.WriteLog($"{_game} Status: GAME NOT INSTALLED (Line 75)");
            MessageBox.Show($"{_game} is not installed.\nAborting uninstall process.");
        }
    }

    /// <summary>Function that returns if a game is installed or not.</summary>
    /// <param name="_game">The game to check if installed.</param>
    /// <param name="_pathfile">The pathfile of game.</param>
    /// <returns>Returns bool value for if game is installed or not.</returns>
    public static bool IsGameInstalled(string _game, string _pathfile)
    {
        if (Directory.Exists($"{_pathfile}/{_game}"))
            return true;
        else
            return false;
    }
}

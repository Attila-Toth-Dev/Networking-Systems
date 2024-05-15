﻿using System.Diagnostics;
using System.IO.Compression;

namespace MGC_Application;

public static class LocalFiles
{
    /// <summary>Function for running the exe file of installed game.</summary>
    /// <param name="_game">The game to run the .exe of.</param>
    /// <param name="_pathfile">The pathfile of said game.</param>
    public static void ExecuteGame(string _game, string _pathfile)
    {
        try
        {
            DebugLogger.WriteLog($"{_game} spooling up game.");

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = $"{_pathfile}/{_game}/{_game}.exe";
            process.Start();
        }
        catch(FileLoadException ex)
        {
            DebugLogger.WriteLog($"Error starting up {_game}, {ex.Message}.");
        }
    }

    /// <summary>Function for extracting newly downloaded files from FTP server.</summary>
    /// <param name="_game">The game of which to extract files from.</param>
    /// <param name="_pathfile">The pathfile of said game zip.</param>
    public static bool InstallGame(string _game, string _pathfile)
    {
        string start = $"{_pathfile}/{_game}.zip";
        string end = $"{_pathfile}/{_game}";

        ZipFile.ExtractToDirectory(start, end);
        Thread.Sleep(1000);
        File.Delete(start);

        return true;
    }

    /// <summary>Function for uninstalling game</summary>
    /// <param name="_game">The game that will be uninstalled.</param>
    /// <param name="_pathfile">The path of game.</param>
    public static bool UninstallGame(string _game, string _pathfile)
    {
        DialogResult dialogResult = MessageBox.Show($"Are you sure you would like to uninstall {_game}?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
            string dir = $"{_pathfile}/{_game}";

            File.Delete($"{_pathfile}/{_game}.zip");
            Directory.Delete(dir, true);

            return true;
        }

        return false;
    }

    /// <summary>Function that returns if a game is installed or not.</summary>
    /// <param name="_game">The game to check if installed.</param>
    /// <param name="_pathfile">The pathfile of game.</param>
    /// <returns>Returns bool value for if game is installed or not.</returns>
    public static bool IsGameInstalled(string _game, string _pathfile)
    {
        if (Directory.Exists($"{_pathfile}/{_game}"))
        {
            DebugLogger.WriteLog($"{_game} Status: INSTALLED");
            return true;
        }
        else
        {
            DebugLogger.WriteLog($"{_game} Status: NOT-INSTALLED");
            return false;
        }
    }
}

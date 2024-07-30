using System.Diagnostics;
using System.IO.Compression;
using MGC_Application.Forms;

namespace MGC_Application.Tools;

public class FileTools
{
    public static string? CurrentGame;

    /// <summary>Run executes the exe of the game.</summary>
    /// <param name="_game">The program of to run the exe of.</param>
    /// <param name="_localPath">The path file of the game.</param>
    public static bool ExecuteGameFiles(string _game, string _localPath)
    {
        // try to execute the .exe of the given game,
        // if game cannot be executed, then run exception error.
        try
        {
            using (Process process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = $"{_localPath}/{_game}/{_game}.exe";
                process.Start();
            }

            Debug.Log($"Booting {_game} files.");
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary>Install extracts and installs the game files in its own directory.</summary>
    /// <param name="_game">The game of which will be installed.</param>
    /// <param name="_localPath">The path file of which the game files are located at.</param>
    public static bool InstallGameFiles(string _game, string _localPath)
    {
        // try to extract the downloaded .zip
        // into its own game directory within path file.
        // if it cannot be executed, throw file not found exception.
        try
        {
            var startFile = $"{_localPath}/{_game}.zip";
            var endDir = $"{_localPath}/{_game}";

            ZipFile.ExtractToDirectory(startFile, endDir);
            Thread.Sleep(1000);

            Debug.Log($"Finished installing {_game} files.");
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary>Uninstall removes the game files from the games folder.</summary>
    /// <param name="_game">The game of which to remove.</param>
    /// <param name="_localPath">The filepath of the chosen game.</param>
    public static bool UninstallGameFiles(string _game, string _localPath)
    {
        try
        {
            DeleteDirectory(_game, _localPath);
            Thread.Sleep(2000);

            try
            {
                DeleteFile(_game, _localPath);
            }
            catch (FileNotFoundException ex)
            {
                Debug.LogException(ex);
                throw;
            }

            Debug.Log($"Finished uninstalling {_game} files.");
            return true;
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary>Verify if the game is installed.</summary>
    /// <param name="_game">The game of which to check installation of.</param>
    /// <param name="_localPath">The path file of the installed game.</param>
    public static bool VerifyGameFiles(string _game, string _localPath)
    {
        var dir = $"{_localPath}/{_game}";

        // verify if the game has been installed in path file.
        try
        {
            if (Directory.Exists(dir))
            {
                Debug.Log($"{dir} directory has been found.");
                return true;
            }
            else
            {
                Debug.Log($"{dir} does not exist.");
                return false;
            }
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary>Creates a directory in the system files.</summary>
    /// <param name="_directoryPath">The name for the directory.</param>
    /// <param name="_toReCreate">If the directory needs to be re-made on load.</param>
    public static void CreateDirectory(string _directoryPath, bool _toReCreate = false)
    {
        try
        {
            // if directory is not real, create a new directory in path file.
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
                Debug.Log($"{_directoryPath}: directory has been created.");
            }

            // else if user would like to delete and recreate directory
            // in the path file.
            else if (Directory.Exists(_directoryPath) && _toReCreate)
            {
                Directory.Delete(_directoryPath, true);
                Directory.CreateDirectory(_directoryPath);
                Debug.Log($"{_directoryPath}: directory has been re-created.");
            }
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }

    /// <summary>Function simplifies dialog creation function.</summary>
    /// <param name="_message">The message the user wants to output to log and dialog.</param>
    /// <param name="_severity">The severity level of the dialog.</param>
    public static void ShowDialogMessage(string _message, int _severity = 0)
    {
        // get the severity of the dialog box message.
        var messageSeverity = _severity switch
        {
            0 => DialogBoxForm.MessageSeverity.MESSAGE,
            1 => DialogBoxForm.MessageSeverity.WARNING,
            2 => DialogBoxForm.MessageSeverity.ERROR,
            _ => DialogBoxForm.MessageSeverity.MESSAGE
        };

        DialogBoxForm dialog = new DialogBoxForm(messageSeverity, _message);
        dialog.ShowDialog();
    }

    /// <summary>This function deletes a given directory.</summary>
    /// <param name="_game">The game directory to delete.</param>
    /// <param name="_localPath">The path of the directory to delete.</param>
    public static void DeleteDirectory(string _game, string _localPath)
    {
        try
        {
            var dir = $"{_localPath}/{_game}";
            Directory.Delete(dir, true);
            Debug.Log($"{dir}: directory has been deleted.");
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }

    /// <summary>This function deletes a given file.</summary>
    /// <param name="_game">The game file to delete.</param>
    /// <param name="_localPath">The path of the file to delete.</param>
    public static void DeleteFile(string _game, string _localPath)
    {
        try
        {
            var file = $"{_localPath}/{_game}.zip";
            File.Delete(file);
            Debug.Log($"{file}: file has been deleted.");
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }
}

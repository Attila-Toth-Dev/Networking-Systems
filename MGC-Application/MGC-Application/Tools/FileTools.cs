using MGC_Application.Forms;
using System.Diagnostics;
using System.IO.Compression;

namespace MGC_Application;

public class FileTools
{
    public static string? currentGame;

    /// <summary>Run executes the exe of the game.</summary>
    /// <param name="_game">The program of to run the exe of.</param>
    /// <param name="_localPath">The pathfile of the game.</param>
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

            Debug.Log($"Executing {_game}.exe");
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Install extracts and installs the game files in its own directory.</summary>
    /// <param name="_game">The game of which will be installed.</param>
    /// <param name="_localPath">The pathfile of which the game files are located at.</param>
    public static bool InstallGameFiles(string _game, string _localPath)
    {
        // try to extract the downloaded .zip
        // into its own game directory within pathfile.
        // if it cannot be executed, throw file not found exception.
        try
        {
            string startFile = $"{_localPath}/{_game}.zip";
            string endDir = $"{_localPath}/{_game}";

            ZipFile.ExtractToDirectory(startFile, endDir);
            Thread.Sleep(1000);

            Debug.Log($"Installed {_game} game files.");
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Uninstall removes the game files from the games folder.</summary>
    /// <param name="_game">The game of which to remove.</param>
    /// <param name="_pathfile">The filepath of the chosen game.</param>
    public static bool UninstallGameFiles(string _game, string _localPath)
    {
        try
        {
            DeleteFile(_game, _localPath);
            Thread.Sleep(2000);
            DeleteDirectory(_game, _localPath);

            Debug.Log($"Uninstalled {_game} game files.");
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Verifys if the game is installed.</summary>
    /// <param name="_game">The game of which to check installation of.</param>
    /// <param name="_localPath">The pathfile of the installed game.</param>
    public static bool VerifyGameFiles(string _game, string _localPath)
    {
        string dir = $"{_localPath}/{_game}";

        // verify if the game has been installed in pathfile.
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
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Creates a directory in the system files.</summary>
    /// <param name="_folderName">The name for the directory.</param>
    /// <param name="_toReCreate">If the directory needs to be re-made on load.</param>
    public static void CreateDirectory(string _filePath, bool _toReCreate = false)
    {
        try
        {
            // if directory is not real, create a new directory in pathfile.
            if (!Directory.Exists(_filePath))
            {
                Directory.CreateDirectory(_filePath);
                Debug.Log($"{_filePath}: dirctory has been created.");
            }

            // else if user would like to delete and recreate directoy
            // in the pathfile.
            else if (Directory.Exists(_filePath) && _toReCreate)
            {
                Directory.Delete(_filePath, true);
                Directory.CreateDirectory(_filePath);
                Debug.Log($"{_filePath}: directory has been re-created.");
            }
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.Log(ex.Message);
        }
    }

    /// <summary>Function simplifies dialog creation function.</summary>
    /// <param name="_message">The message the user wants to output to log and dialog.</param>
    /// <param name="_severity">The severity level of the dialog.</param>
    public static void ShowDialogMessage(string _message, int _severity = 0)
    {
        // get the severity of the dialog box message.
        DialogBoxForm.MessageSeverity messageSeverity;
        switch (_severity)
        {
            case 0:
                messageSeverity = DialogBoxForm.MessageSeverity.MESSAGE;
                break;

            case 1:
                messageSeverity = DialogBoxForm.MessageSeverity.WARNING;
                break;

            case 2:
                messageSeverity = DialogBoxForm.MessageSeverity.ERROR;
                break;

            default:
                messageSeverity = DialogBoxForm.MessageSeverity.MESSAGE;
                break;
        }

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
            string dir = $"{_localPath}/{_game}";
            Directory.Delete(dir, true);
            Debug.Log($"{dir}: directory has been deleted.");
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.Log(ex.Message);
        }
    }

    /// <summary>This function deletes a given file.</summary>
    /// <param name="_game">The game file to delete.</param>
    /// <param name="_localPath">The path of the file to delete.</param>
    public static void DeleteFile(string _game, string _localPath)
    {
        try
        {
            string file = $"{_localPath}/{_game}.zip";
            File.Delete(file);
            Debug.Log($"{file}: file has been deleted.");
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
        }
    }
}

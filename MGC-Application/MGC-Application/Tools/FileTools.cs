using System.Diagnostics;
using System.IO.Compression;
using MGC_Application.Forms;

namespace MGC_Application.Tools;

public class FileTools
{
    /** Replace MGC-Data with own file names **/
    public static string GamesDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/MGC-Data";
    public static string DataDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/MGC-Data";
    
    public static string LogPathFile = $@"{DataDirectory}/Logs";
    public static string UsersPathFile = $@"{DataDirectory}";

    /// <summary>
    /// Initiate process of running a game from the launcher instance.
    /// </summary>
    /// <param name="_game">Game of which to start up.</param>
    /// <param name="_localPath">Local path of game.</param>
    /// <returns>Returns true if able to start process, false otherwise.</returns>
    public static bool ExecuteGameFiles(string _game, string _localPath)
    {
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

    /// <summary>
    /// Install game files extracts contents from newly installed files and creates new directory for game.
    /// </summary>
    /// <param name="_game">Game of which to extract game files from.</param>
    /// <param name="_localPath">Local path of which to install game files.</param>
    /// <returns>Returns true if all game contents have been installed, false otherwise.</returns>
    public static bool InstallGameFiles(string _game, string _localPath)
    {
        var startFile = $"{_localPath}/{_game}.zip";
        var endDir = $"{_localPath}/{_game}";

        try
        {
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

    /// <summary>
    /// Uninstall and delete all game files from local path.
    /// </summary>
    /// <param name="_game">Game of which to uninstall game files for.</param>
    /// <param name="_localPath">Local path of game.</param>
    /// <returns>Returns true if all game files of selected game have been removed, false otherwise.</returns>
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

    /// <summary>
    /// Verify if said game files already exist.
    /// </summary>
    /// <param name="_game">Game to verify.</param>
    /// <param name="_localPath">Local path of game.</param>
    /// <returns>Returns true if valid exists, false otherwise.</returns>
    public static bool VerifyGameFiles(string _game, string _localPath)
    {
        var dir = $"{_localPath}/{_game}";

        try
        {
            if (Directory.Exists(dir))
            {
                Debug.Log($"{dir} path is valid.");
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

    /// <summary>
    /// Creates a custom file directory in given location.
    /// </summary>
    /// <param name="_directoryPath">Path of directory to create.</param>
    /// <param name="_toReCreate">Set to true if directory should be remade.</param>
    public static void CreateDirectory(string _directoryPath, bool _toReCreate = false)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);

            else if (Directory.Exists(_directoryPath) && _toReCreate)
            {
                Directory.Delete(_directoryPath, true);
                Directory.CreateDirectory(_directoryPath);
            }
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }

    /// <summary>
    /// Enables dialog boxes to be shown.
    /// </summary>
    /// <param name="_message">Message of which to display on dialog box.</param>
    /// <param name="_severity">The severity warning from 0 to 2, 0 - MESSAGE, 1 - WARNING, 2 - ERROR</param>
    public static void ShowDialogMessage(string _message, int _severity = 0)
    {
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

    /// <summary>
    /// Deletes given directory.
    /// </summary>
    /// <param name="_directory">Directory of which to delete directory of.</param>
    /// <param name="_localPath">Local path of directory to be deleted.</param>
    public static void DeleteDirectory(string _directory, string _localPath)
    {
        var dir = $"{_localPath}/{_directory}";
     
        try
        {
            Directory.Delete(dir, true);
            Debug.Log($"{dir}: directory has been deleted.");
        }
        catch(DirectoryNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }

    /// <summary>
    /// Deletes given file.
    /// </summary>
    /// <param name="_file">File of which to delete.</param>
    /// <param name="_localPath">Local path of file to delete.</param>
    public static void DeleteFile(string _file, string _localPath)
    {
        var file = $"{_localPath}/{_file}.zip";

        try
        {
            File.Delete(file);
            
            Debug.Log($"{file} has been deleted.");
        }
        catch(FileNotFoundException ex)
        {
            Debug.LogException(ex);
        }
    }
}

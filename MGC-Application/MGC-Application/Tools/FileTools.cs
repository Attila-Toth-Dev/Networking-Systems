using System.Diagnostics;
using System.IO.Compression;
using MGC_Application.Forms;

namespace MGC_Application.Tools;

public class FileTools
{
    public static string GamesDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/MGC-Games";
    public static string DataDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/MGC-Data";
    
    public static string LogPathFile = $@"{DataDirectory}/Logs";
    public static string UsersPathFile = $@"{DataDirectory}";

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

    public static void DeleteDirectory(string _game, string _localPath)
    {
        var dir = $"{_localPath}/{_game}";
     
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

    public static void DeleteFile(string _game, string _localPath)
    {
        var file = $"{_localPath}/{_game}.zip";

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

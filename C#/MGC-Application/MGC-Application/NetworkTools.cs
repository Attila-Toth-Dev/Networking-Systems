using System.Diagnostics;
using System.Net;

namespace MGC_Application;

public static class NetworkTools
{
    public static string ServerIP { get; set; }

    public static bool CheckValidFTP(string _serverIP, string _username, string _password)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/");
        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

        request.Credentials = new NetworkCredential(_username, _password);
        request.Timeout = 1000;

        var stopwatch = Stopwatch.StartNew();

        try
        {
            request.GetResponse();
            MessageBox.Show($"FTP request recieved after {stopwatch.Elapsed}.\n" +
                $"Connection established with {_serverIP}.");

            ServerIP = _serverIP;

            return true;
        }
        catch (WebException ex)
        {
            MessageBox.Show($"FTP request failed after {stopwatch.Elapsed}.\n" +
                $"{ex.Message}");

            return false;
        }
    }

    public static void DownloadFTPFile(string _serverIP, string _username, string _password, string _game)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Games/{_game}.zip");
        request.Method = WebRequestMethods.Ftp.DownloadFile;

        request.Credentials = new NetworkCredential(_username, _password);
    }

    public static bool IsGameDownloaded(string _severIP, string _username, string _password, string _game)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_severIP}/Games/{_game}");
        request.Method = WebRequestMethods.Ftp.GetFileSize;

        request.Credentials = new NetworkCredential(_username, _password);

        try
        {
            request.GetResponse();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static void RunInstalledGame(string _serverIP, string _username, string _password, string _game)
    {

    }
}

using System.Diagnostics;
using System.Net;

namespace MGC_Application;

public static class NetworkTools
{
    public static string? ServerIP { get; set; }
    public static string? Username { get; set; }
    public static string? Password { get; set; }

    public static bool CheckValidFTP(string _serverIP, string _username, string _password)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Games");
        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

        request.Credentials = new NetworkCredential(_username, _password);
        request.Timeout = 1000;

        var stopwatch = Stopwatch.StartNew();

        try
        {
            request.GetResponse();
            MessageBox.Show($"FTP request recieved after {stopwatch.Elapsed}.\n" +
                $"Connection established with {_serverIP}.");

            stopwatch.Stop();

            return true;
        }
        catch (WebException ex)
        {
            MessageBox.Show($"FTP request failed after {stopwatch.Elapsed}.\n" +
                $"{ex.Message}");

            stopwatch.Stop();

            return false;
        }
    }

    public static void DownloadGameFromFtp(string _game, string _pathFile)
    {
        string dir = $"{_pathFile}/";

        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ServerIP}/Games/");
    }
}

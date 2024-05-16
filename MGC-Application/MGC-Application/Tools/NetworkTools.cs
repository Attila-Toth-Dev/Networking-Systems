using System.Diagnostics;
using System.Net;

namespace MGC_Application;

public static class NetworkTools
{
    public static string? ServerIP { get; set; }
    public static string? Username { get; set; }
    public static string? Password { get; set; }

    /// <summary>Checks if there is a valid connection between client and server.</summary>
    /// <param name="_serverIP">The server IP.</param>
    /// <param name="_username">The username of the client.</param>
    /// <param name="_password">The password of the client.</param>
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
            stopwatch.Stop();

            return true;
        }
        catch (WebException ex)
        {
            stopwatch.Stop();

            return false;
        }
    }

    /// <summary>Grabs the .zip files of the games from the server.</summary>
    /// <param name="_game">The game of which to grab the files for.</param>
    /// <param name="_pathFile">The path of which to install the game to.</param>
    public static bool DownloadGameFromFtp(string _game, string _pathFile)
    {
        string dir = $"{_pathFile}/{_game}.zip";
        string file = $"{_game}.zip";

        string serverDir = $"ftp://{ServerIP}/Games/{file}";

        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverDir);
        request.Credentials = new NetworkCredential(Username, Password);
        request.UseBinary = true;
        request.Method = WebRequestMethods.Ftp.DownloadFile;

        var stopwatch = Stopwatch.StartNew();

        try
        {
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            FileStream writer = new FileStream(dir, FileMode.Create);

            long length = response.ContentLength;
            int bufferSize = 2048;
            int readCount;
            byte[] buffer = new byte[2048];

            readCount = responseStream.Read(buffer, 0, bufferSize);
            while (readCount > 0)
            {
                writer.Write(buffer, 0, readCount);
                readCount = responseStream.Read(buffer, 0, bufferSize);
            }

            responseStream.Close();
            response.Close();
            writer.Close();

            stopwatch.Stop();

            Thread.Sleep(1000);

            return true;
        }
        catch (WebException ex)
        {
            stopwatch.Stop();

            return false;
        }
    }
}

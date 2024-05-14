using System.Diagnostics;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

    public static bool DownloadGameFromFtp(string _game, string _pathFile)
    {
        string dir = $"{_pathFile}/{_game}.zip";
        string file = $"{_game}.zip";

        string serverDir = $"ftp://{ServerIP}/Games/{file}";

        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverDir);
        request.Credentials = new NetworkCredential(Username, Password);
        request.UseBinary = true; // Use binary to ensure correct dlv!
        request.Method = WebRequestMethods.Ftp.DownloadFile;

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

            MessageBox.Show($"Successfully downloaded {_game} files from server.");

            return true;
        }
        catch(WebException ex)
        {
            MessageBox.Show($"Unable to download {_game}.zip.\nStatus: {ex.Message}");
            return false;
        }
    }
}

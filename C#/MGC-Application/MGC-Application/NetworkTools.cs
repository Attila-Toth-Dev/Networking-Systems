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
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Games/{_game}");
        request.Method = WebRequestMethods.Ftp.DownloadFile;

        var stopwatch = Stopwatch.StartNew();

        request.Credentials = new NetworkCredential(_username, _password);

        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

        Stream responseStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(responseStream);

        MessageBox.Show($"Download Complete: {response.StatusDescription}\nDownload Time: {stopwatch.Elapsed}");

        using (StreamWriter file = File.CreateText(_game))
        {
            file.WriteLine(reader.ReadToEnd());
            file.Close();
        }

        reader.Close();
        response.Close();
    }
}

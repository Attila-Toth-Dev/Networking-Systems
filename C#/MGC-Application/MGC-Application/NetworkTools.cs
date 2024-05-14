using System.Net;

namespace MGC_Application;

public static class NetworkTools
{
    public static string? ServerIP { get; set; }
    public static string? Username { get; set; }
    public static string? Password { get; set; }

    /// <summary>Function that checks if there is a valid connection to FTP server.</summary>
    /// <param name="_serverIP">The IP that is used to create a gateway to FTP server.</param>
    /// <param name="_username">The username of the FTP account.</param>
    /// <param name="_password">The password of the FTP account.</param>
    /// <returns>Returns a bool value if the connection was successful to the server.</returns>
    public static bool CheckValidFTP(string _serverIP, string _username, string _password)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Games");
        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

        request.Credentials = new NetworkCredential(_username, _password);
        request.Timeout = 1000;

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

    /// <summary>Function that makes a request to FTP server to allow for downloading of game zip files.</summary>
    /// <param name="_game">The game that is requested to be downloaded.</param>
    /// <param name="_pathFile">The path file the game will be installed to.</param>
    /// <returns>Returns a bool of either true or false if the file was able to be downloaded.</returns>
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

            Thread.Sleep(1000);

            return true;
        }
        catch
        {
            return false;
        }
    }
}

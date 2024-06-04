using System.Net;
using System.Net.NetworkInformation;

namespace MGC_Application;

public class Networking
{
    #region Getters/Setters

    public static string? ServerIP { get; set; }

    public static string? Username { get; set; }
    
    public static string? Password { get; set; }
    
    #endregion

    /// <summary>Checks if there is a valid connection between client and server.</summary>
    /// <param name="_serverIP">The server IP.</param>
    /// <param name="_username">The username of the client.</param>
    /// <param name="_password">The password of the client.</param>
    public static bool CheckValidFTP(string _serverIP)
    {
        // check to see if the given IP is a valid address.
        if (IsValidIP(_serverIP, 5))
        {
            try
            {
                // if true, create a FTP web request to remote host
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Games");

                request.Credentials = new NetworkCredential(Username, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.ServicePoint.ConnectionLimit = 4;
                request.KeepAlive = false;

                // try to get response from remote host
                request.GetResponse();

                Debug.Log($"{_serverIP}: connection has been made.");
                return true;
            }
            catch (WebException ex)
            {
                // else, prompt with web exception error.
                Debug.Log(ex.Message);
                return false;
            }
        }
        else
            return false;
    }

    /// <summary>Grabs the .zip files of the games from the server.</summary>
    /// <param name="_game">The game of which to grab the files for.</param>
    /// <param name="_pathFile">The path of which to install the game to.</param>
    public static bool DownloadGameFromFtp(string _game)
    {
        try
        {
            // create a FTP web request to remote host to initialize
            // connection with host.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ServerIP}/Games/{_game}.zip");

            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.ServicePoint.ConnectionLimit = 4;
            request.UseBinary = true;
            request.KeepAlive = false;

            // try to write the data of the .zip from
            // server to local machine local pathfile.
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                string dir = $"{WelcomeForm.gamesPathFile}/{_game}.zip";
            
                long length = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[2048];

                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream writer = new FileStream(dir, FileMode.Create))
                    {
                        readCount = responseStream.Read(buffer, 0, bufferSize);
                        while (readCount > 0)
                        {
                            writer.Write(buffer, 0, readCount);
                            readCount = responseStream.Read(buffer, 0, bufferSize);
                        }
                    }
                }
            }

            Thread.Sleep(1000);

            Debug.Log($"{_game} has been downloaded from remote host.");
            return true;
        }
        catch (WebException ex)
        {
            // else throw a webexception error. 
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Function checks the file size of the selected game zip file on remote server.</summary>
    /// <param name="_game">The game to check file size of.</param>
    public static long CheckForUpdate(string _game)
    {
        try
        {
            // create a FTP web request connection to address
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{ServerIP}/Games/{_game}.zip");

            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.KeepAlive = false;
            request.Proxy = null;

            // try to get the file size of the copy
            // of game from remote host for update sizing.
            FtpWebResponse responseSize = (FtpWebResponse)request.GetResponse();
            long fileSize = responseSize.ContentLength;
            responseSize.Close();

            Debug.Log($"File size is {fileSize}.");
            return fileSize;
        }
        catch(WebException ex)
        {
            // else return web exception error.
            Debug.Log(ex.Message);
            return 0;
        }
    }

    /// <summary>Checks to see if the IP address entered is correctly formatted and is valid.</summary>
    /// <param name="_serverIP">The IP address to check validation.</param>
    /// <param name="_timeout">The timeout time for the ping.</param>
    public static bool IsValidIP(string _serverIP, int _timeout)
    {
        try
        {
            // try to ping the address to check if it is a true address,
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(_serverIP, _timeout);

            Debug.Log($"Ping connection recieved with remote server.");
            return true;
        }
        catch (PingException ex)
        {
            // catch return ping exception error.
            Debug.Log(ex.Message);
            return false;
        }
    }

    /// <summary>Function that gains access to FTP server credentials.</summary>
    /// <param name="_username">The username of account.</param>
    /// <param name="_password">The password of account.</param>
    public static bool FTPCredentialsCheck(string _username, string _password)
    {
        try
        {
            return true;
        }
        catch(FileNotFoundException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
        catch(WebException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }
}

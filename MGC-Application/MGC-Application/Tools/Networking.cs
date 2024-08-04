using System.Net;
using System.Net.NetworkInformation;

namespace MGC_Application.Tools;

public class Networking
{
    #region Getters/Setters

    public static string ServerIp = "58.169.146.100";
    public static string Username = "ftp-user";
    public static string Password = "mn1-237A";
    
    #endregion

    /// <summary>Checks if there is a valid connection between client and server.</summary>
    /// <param name="_serverIp">The server IP.</param>
    public static bool ValidateRemoteConnection(string _serverIp)
    {
        // check to see if the given IP is a valid address.
        if (ValidateAddress(_serverIp, 5))
        {
            // if true, create an FTP web request to remote host
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIp}/Games");
            
            try
            {
                request.Credentials = new NetworkCredential(Username, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.ServicePoint.ConnectionLimit = 4;
                request.KeepAlive = false;

                // try to get response from remote host
                request.GetResponse();

                Debug.Log($"Connection to {ServerIp} was made.");
                return true;
            }
            catch (WebException ex)
            {
                // else, prompt with web exception error.
                Debug.LogException(ex);
                return false;
            }
        }
            
        return false;
    }

    /// <summary>Checks to see if the IP address entered is correctly formatted and is valid.</summary>
    /// <param name="_serverIP">The IP address to check validation.</param>
    /// <param name="_timeout">The timeout time for the ping.</param>
    public static bool ValidateAddress(string _serverIP, int _timeout)
    {
        try
        {
            // try to ping the address to check if it is a true address,
            Ping ping = new Ping();
            PingReply pingReply = ping.Send(_serverIP, _timeout);

            Debug.Log($"Remote server {ServerIp} received ping.");
            return true;
        }
        catch (PingException ex)
        {
            // catch return ping exception error.
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary></summary>
    /// <param name="_game"></param>
    /// <param name="_remotePath"></param>
    public static bool DownloadGameFiles(string _game, string _remotePath)
    {
        // create a FTP web request to remote host to initialize
        // connection with host.
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{_remotePath}/{_game}.zip");

        try
        {
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.ServicePoint.ConnectionLimit = 4;
            request.UseBinary = true;
            request.KeepAlive = false;

            // try to write the data of the .zip from
            // server to local machine local pathfile.
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                string dir = $"{FileTools.GamesDirectory}/{_game}.zip";
            
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

            Debug.Log($"{_game} files successfully downloaded.");
            return true;
        }
        catch (WebException ex)
        {
            // else throw a web exception error. 
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary></summary>
    /// <param name="_game"></param>
    /// <param name="_remotePath"></param>
    public static long ValidateUpdate(string _game, string _remotePath)
    {
        // create a FTP web request connection to address
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{_remotePath}/{_game}.zip");

        try
        {
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
            Debug.LogException(ex);
            return -1;
        }
    }

    /// <summary></summary>
    /// <param name="_remotePath"></param>
    /// <param name="_file"></param>
    public static bool DownloadFiles(string _remotePath, string _file)
    {
        // create an FTP web request to remote host to initialize
        // connection with host.
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remotePath);

        try
        {
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.ServicePoint.ConnectionLimit = 4;
            request.UseBinary = true;
            request.KeepAlive = false;

            // try to write the data of the .zip from
            // server to local machine local path file.
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                string dir = $"{_remotePath}/{_file}";

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

            return true;
        }
        catch(WebException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    /// <summary></summary>
    /// <param name="_file"></param>
    /// <param name="_localPath"></param>
    /// <param name="_remotePath"></param>
    public static bool UploadFiles(string _file, string _localPath, string _remotePath)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_remotePath);
        
        try
        {
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead($"{_localPath}/{_file}"))
            using (Stream ftpStream = request.GetRequestStream())
                fileStream.CopyTo(ftpStream);

            Debug.Log($"Uploaded {_file} to remote host.");
            return true;
        }
        catch (WebException ex)
        {
            Debug.Log(ex.Message);
            return false;
        }
    }
}

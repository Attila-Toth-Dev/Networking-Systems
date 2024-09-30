﻿using System.Net;
using System.Net.NetworkInformation;

namespace MGC_Application.Tools;

public class Networking
{
    #region Getters/Setters

    public static string ServerIp = "58.169.146.100";
    public static string Username = "ftp-user";
    public static string Password = "mn1-237A";
    
    #endregion

    public static bool ValidateRemoteConnection(string _serverIp)
    {
        if (ValidateAddress(_serverIp, 20))
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIp}/");
            
            try
            {
                request.Credentials = new NetworkCredential(Username, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                request.ServicePoint.ConnectionLimit = 4;
                request.KeepAlive = false;

                request.GetResponse();

                Debug.Log($"Connection to {ServerIp} was made.");
                return true;
            }
            catch (WebException ex)
            {
                Debug.LogException(ex);
                return false;
            }
        }
            
        return false;
    }

    public static bool ValidateAddress(string _serverIp, int _timeout)
    {
        try
        {
            Debug.Log("--- Validating Server IP ---");

            Ping[] pings = new Ping[10];

            for (int i = 0; i < pings.Length; i++)
            {
                pings[i] = new Ping();
            }

            long totalPingTime = 0;
            for (int i = 0; i < pings.Length; i++)
            {
                Ping ping = pings[i];
                PingReply pingReply = ping.Send(_serverIp, _timeout);

                Debug.Log($"Ping {i} Round Trip Time: {pingReply.RoundtripTime}");
                Debug.Log($"Ping {i} Status: {pingReply.Status}");
                totalPingTime += pingReply.RoundtripTime;
            }

            long averagePingTime = totalPingTime / pings.Length;

            Debug.Log("--- Round Trip Times ---");
            Debug.Log($"Total ping time : {totalPingTime}");
            Debug.Log($"Average ping time : {averagePingTime}");
            Debug.Break();

            return true;
        }
        catch (PingException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    public static bool DownloadGameFiles(string _game, string _remotePath)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{_remotePath}/{_game}.zip");
            
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.ServicePoint.ConnectionLimit = 4;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                string dir = $"{FileTools.GamesDirectory}/{_game}.zip";
            
                long length = response.ContentLength;
                Debug.Log($"{_game} content size: {length}");

                int bufferSize = 2048;
                //int readCount;
                byte[] buffer = new byte[2048];

                using (Stream responseStream = response.GetResponseStream())
                {
                    using (FileStream writer = new FileStream(dir, FileMode.Create))
                    {
                        int readCount = responseStream.Read(buffer, 0, bufferSize);
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
            Debug.Break();
            return true;
        }
        catch (WebException ex)
        {
            Debug.LogException(ex);
            return false;
        }
    }

    public static long ValidateUpdate(string _game, string _remotePath)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{_remotePath}/{_game}.zip");
            
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;
            request.KeepAlive = false;
            request.Proxy = null;

            FtpWebResponse responseSize = (FtpWebResponse)request.GetResponse();
            long fileSize = responseSize.ContentLength;
            
            responseSize.Close();

            Debug.Log($"File size is {fileSize}.");
            return fileSize;
        }
        catch(WebException ex)
        {
            Debug.LogException(ex);
            return -1;
        }
    }

    public static bool DownloadFiles(string _remotePath, string _file)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{_remotePath}/{_file}");
            
            request.Credentials = new NetworkCredential(Username, Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.ServicePoint.ConnectionLimit = 4;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                string dir = $"{FileTools.UsersPathFile}/{_file}";

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

using System.Net;

namespace MGC_Application;

public static class NetworkTools
{
    public static string ServerIP { get; set; }

    public static bool CheckValidFTP(string _serverIP)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{_serverIP}/Welcome");
        request.Credentials = new NetworkCredential("ftp-user", "mn1-237A");
        request.Method = WebRequestMethods.Ftp.GetFileSize;

        try
        {
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            MessageBox.Show("Connection Valid: True");
            return true;
        }
        catch (WebException ex)
        {
            FtpWebResponse response = (FtpWebResponse)ex.Response;
            if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
            {
                MessageBox.Show("Connection not possible: FALSE");
                return false;
            }
        }

        return false;
    }
}

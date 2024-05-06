using System.Net;
using System.Net.Sockets;

namespace MGC_Application;

public static class NetworkTools
{
    /// <summary>The function pings the server client to see if user is able to connect to.</summary>
    /// <param name="_serverIP">The IP location the user wants to connect to.</param>
    /// <param name="_port">The specific port to connect to.</param>
    /// <returns>Returns true or false depending if connection was successful or not.</returns>
    public static bool IsValidIP(string _serverIP, int _port)
    {
        try
        {
            using (var client = new TcpClient(_serverIP, _port))
                MessageBox.Show($"Succesful connection to host: {_serverIP}:{_port}");
            
            return true;
        }
        catch
        {
            MessageBox.Show($"Unable to connect to Server\n Please try again.");
            return false;
        }
    }
}

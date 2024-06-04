using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkCommandLine : MonoBehaviour
{
    private NetworkManager netManager;

    private void Start()
    {
        netManager = GetComponentInParent<NetworkManager>();

        if (Application.isEditor)
            return;

        var args = GetCommandLineArgs();
        
        if(args.TryGetValue("-mode", out string mode))
        {
            switch(mode)
            {
                case "server":
                    netManager.StartServer();
                    break;

                case "host":
                    netManager.StartHost();
                    break;

                case "client":
                    netManager.StartClient();
                    break;
            }
        }
    }

    private Dictionary<string, string> GetCommandLineArgs()
    {
        Dictionary<string, string> argDictionary = new Dictionary<string, string>();

        var args = Environment.GetCommandLineArgs();

        for (int i = 0; i < args.Length; i++)
        {
            var arg = args[i].ToLower();
            if(arg.StartsWith("-"))
            {
                var value = i < args.Length - 1 ? args[i + 1].ToLower() : null;
                value = (value?.StartsWith("-") ?? false) ? null : value;

                argDictionary.Add(arg, value);
            }
        }

        return argDictionary;
    }
}

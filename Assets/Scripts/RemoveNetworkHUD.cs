using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RemoveNetworkHUD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject netMGR = GameObject.Find("NetworkManager");
        NetworkManagerHUD netMgrHUD = netMGR.GetComponent<NetworkManagerHUD>();
        netMgrHUD.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

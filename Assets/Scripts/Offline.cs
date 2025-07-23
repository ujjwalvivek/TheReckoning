using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Offline : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.OfflineMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

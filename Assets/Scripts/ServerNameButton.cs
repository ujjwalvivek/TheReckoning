using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class ServerNameButton : MonoBehaviour
{

    [SerializeField] TMP_Text serverText;
    [SerializeField] TMP_Text gmText;

    public RoomInfo info;

    public void Setup(RoomInfo _info)
    {
        
        info = _info;
        serverText.text = _info.Name;
        gmText.text = (string)_info.CustomProperties["GM"];
    }

    public void OnClick()
    {
        Launcher.Instance.JoinRoom(info);
    }
}

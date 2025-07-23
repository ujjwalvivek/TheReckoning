using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerNameTag : MonoBehaviour
{

    PhotonView PV;

    [SerializeField] TMP_Text userNameText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void userName()
    {
        if (PV.IsMine)
        {
            userNameText.text = PhotonNetwork.NickName;
        }
    }
}

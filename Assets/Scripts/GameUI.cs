using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class GameUI : MonoBehaviour
{
    public TMP_Text userNameText;

    // Start is called before the first frame update
    void Start()
    {
        UserNameDisplay();
    }

    void UserNameDisplay()
    {
        Debug.Log(PhotonNetwork.NickName);
        userNameText.text = PlayerPrefs.GetString("PlayerName");
    }
}

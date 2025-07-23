using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class UserNameList : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text userNameText;

    Player player;

    public void SetUp(Player _player)
    {
        player = _player;
        userNameText.text = _player.NickName;
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        //base.OnPlayerLeftRoom(otherPlayer);
        if (player == otherPlayer)
        {
            Destroy(gameObject);
        }
    }

    public override void OnLeftRoom()
    {
        //base.OnLeftRoom();
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using UnityEngine.UI;

public class UserNameList : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text userNameText;
    [SerializeField] Image background;
    [SerializeField] Image strip;
    [SerializeField] TMP_Text initials;

    Player player;

    public void SetUp(Player _player)
    {
        player = _player;
        userNameText.text = _player.NickName;
        initials.text = _player.NickName.Substring(0, 1).ToUpper();
        strip.color = new Color32((byte)Random.Range(0,255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        Color bg;
        bg = strip.color;
        bg.a = 0.39f;
        background.color = bg;

        //if (!PlayerPrefs.HasKey("PlayerName"))
        //{
        //    _player.NickName = "Player " + Random.Range(0, 1000).ToString("0000");
        //    userNameText.text = _player.NickName;
        //    PlayerPrefs.SetString("PlayerName", userNameText.text);
        //}
        //else
        //{
        //    userNameText.text = PlayerPrefs.GetString("PlayerName");
        //}
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

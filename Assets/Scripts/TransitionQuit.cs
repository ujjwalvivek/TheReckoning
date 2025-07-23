using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class TransitionQuit : MonoBehaviour
{
    public static TransitionQuit Instance;

    //Loading Screen
    public GameObject transScreen;

    private void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        GameStart();
    }

    public void GameStart()
    {
        StartCoroutine(LoadGameScene());
    }

    IEnumerator LoadGameScene()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Quitting Debug");
        Application.Quit();
    }

    public void OnApplicationQuit()
    {
        Destroy(RoomManager.Instance.gameObject);
        Debug.Log("Quitting to the desktop");
    }
}

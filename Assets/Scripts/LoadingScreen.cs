using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Michsky.UI.Dark;
using TMPro;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class LoadingScreen : MonoBehaviour
{

    public static LoadingScreen Instance;

    //Inspector exposed Fields
    [SerializeField] TMP_Text loadingText;
    [SerializeField] TMP_Text loadingPercent;
    //[SerializeField] TMP_Text tipText;

    //Loading Screen
    public GameObject loadingScreen;
    public GameObject lobbyScreen;

    //Progress Bar
    public Slider progressBar;

    //Loading Array
    string[] loadingTextArray = { "LOADING.", "LOADING..", "LOADING..." };

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GameStart(4);
    }

    //public void StartGame()
    //{
    //    PhotonNetwork.LoadLevel(1);
    //    GameStart(2);
    //}

    public void GameStart(int sceneIndex)
    {
        StartCoroutine(LoadGameScene(sceneIndex));
        StartCoroutine(LoadingText());
    }

    IEnumerator LoadGameScene(int sceneIndex)
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel(sceneIndex);
        }

        while (PhotonNetwork.LevelLoadingProgress < 1)
        {
            float progress = Mathf.Clamp01(PhotonNetwork.LevelLoadingProgress / .9f);

            progressBar.value = progress;

            int progressValue = (int)(progress * 100);
            //progressBar.fillRect = PhotonNetwork.LevelLoadingProgress;
            loadingPercent.text =  progressValue + "%";

            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator LoadingText()
    {
        loadingText.text = loadingTextArray[0];
        yield return new WaitForSeconds(0.2f);
        loadingText.text = loadingTextArray[1];
        yield return new WaitForSeconds(0.2f);
        loadingText.text = loadingTextArray[2];
        yield return new WaitForSeconds(0.2f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;


public class TransitionLeave : MonoBehaviour
{
    public static TransitionLeave Instance;

    //Inspector exposed Fields
    [SerializeField] TMP_Text transPercent;

    //Loading Screen
    public GameObject transScreen;

    //Progress Bar
    public Slider progressBar;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GameStart(2);
    }

    public void GameStart(int sceneIndex)
    {
        StartCoroutine(LoadGameScene(sceneIndex));
    }

    IEnumerator LoadGameScene(int sceneIndex)
    {
        //Destroy(RoomManager.Instance.gameObject);
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync(sceneIndex);

        while (loadLevel.progress < 1)
        {
            float progress = Mathf.Clamp01(loadLevel.progress / .9f);

            progressBar.value = progress;

            int progressValue = (int)(progress * 100);
            //progressBar.fillRect = PhotonNetwork.LevelLoadingProgress;
            transPercent.text = progressValue + "%";

            yield return new WaitForEndOfFrame();
        }
    }
}

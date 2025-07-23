using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class InternetConnection : MonoBehaviourPunCallbacks
{
    public GameObject init;
    public GameObject verifyStorageGO;
    public GameObject checkInternetGO;

    public GameObject internetCheck;
    public GameObject yes;
    public GameObject no;

    public GameObject fadeIn;

    private void Start()
    {
        init.SetActive(false);
        internetCheck.SetActive(false);

        if (!PhotonNetwork.IsConnected)
        {
            Debug.Log("Connecting to the Master");
            PhotonNetwork.ConnectUsingSettings();
            PhotonNetwork.GameVersion = "1.0";
        }

        ConnectionState();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && yes.activeSelf)
        {
            fadeIn.SetActive(true);
            StartCoroutine(DelayLoadLevel());
        }
    }

    private void ConnectionState()
    {
        StartCoroutine(InitText());
    }

    private IEnumerator DelayLoadLevel()
    {
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene(1);
    }

    IEnumerator InitText()
    {
        init.SetActive(true);
        verifyStorageGO.SetActive(true);
        yield return new WaitForSeconds(3f);
        verifyStorageGO.SetActive(false);

        checkInternetGO.SetActive(true);

        if (checkInternetGO.activeSelf)
        {
            StartCoroutine(LoadGameCoRoutine());
        }
    }

    IEnumerator LoadGameCoRoutine()
    {
        yield return new WaitForSeconds(4f);

        init.SetActive(false);

        if (!init.activeSelf)
        {
            if (!RoomManager.Instance.isConnected)
            {
                StartCoroutine(NoPlayText());
            }

            else
            {
                StartCoroutine(PlayText());
            }
        }
    }

    IEnumerator PlayText()
    {
        yield return new WaitForSeconds(1f);
        internetCheck.SetActive(true);
        yes.SetActive(true);
    }

    IEnumerator NoPlayText()
    {
        yield return new WaitForSeconds(1f);
        internetCheck.SetActive(true);
        no.SetActive(true);
        yes.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

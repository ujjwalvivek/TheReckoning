using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.IO;
public class GameManager : MonoBehaviourPunCallbacks
{
    public static GameManager Instance;

    public PlayerManager playerManager;

    //Singleton Assignment
    private void Awake()
    {
        if (Instance)  //Checks if another Game Manager is already in the scene
        {
            Destroy(gameObject);  //There can be only one >:)
            return;
        }

        DontDestroyOnLoad(gameObject); //I have the high ground
        Instance = this;
    }

    public override void OnEnable()
    {
        base.OnEnable();
    }

    public override void OnDisable()
    {
        base.OnDisable();
    }

    void LeftRoom()
    {
        
    }
}

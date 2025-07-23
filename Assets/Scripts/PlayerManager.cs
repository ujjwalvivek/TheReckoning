using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviourPunCallbacks
{

    PhotonView PV;

    public GameObject controller;
    public GameObject deadController;
    public ParticleSystem DeadFX;
    protected ItemManager leftRoomDrop;
    [HideInInspector] public GameObject leftRoomDropWeapon;

    private void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if(PV.IsMine)
        {
            CreateController();
        }
    }

    // Update is called once per frame
    void CreateController()
    {
        Transform spawnPoint = SpawnManager.Instance.GetSpawnPoint();

        Debug.Log("Instantiated Player Controller");
        controller = PhotonNetwork.Instantiate(Path.Combine("Photon Prefabs", "PlayerController"), spawnPoint.position, spawnPoint.rotation, 0, new object[] { PV.ViewID });
    }

    public void Die()
    {
        PhotonNetwork.Destroy(controller);
        Debug.Log("Instantiated Dead Controller");
        deadController = PhotonNetwork.Instantiate(Path.Combine("Photon Prefabs", "SpectateController"), controller.transform.position + new Vector3(0f, 1f, 0f), controller.transform.rotation, 1, new object[] { PV.ViewID });
        //DeadFX.Emit(2);
    }
}

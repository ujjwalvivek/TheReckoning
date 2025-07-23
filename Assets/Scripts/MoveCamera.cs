using UnityEngine;
using Photon.Pun;

public class MoveCamera : MonoBehaviour 
{

    //PhotonView PV;

    public Transform player;
    public GameObject fpsPlayer;
    public Camera Cam;
    public float wallRunTilt = 25f;


    private void Awake()
    {

    }

    void Update() 
    {
        transform.position = player.transform.position;
    }
}
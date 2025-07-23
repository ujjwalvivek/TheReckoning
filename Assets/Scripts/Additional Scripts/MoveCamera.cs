using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    public GameObject fpsPlayer;
    public Camera Cam;
    public float wallRunTilt = 25f;

    void Update() {
        transform.position = player.transform.position;
    }
}
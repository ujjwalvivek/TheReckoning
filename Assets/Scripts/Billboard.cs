using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Billboard : MonoBehaviour
{
    Camera cam;

    void Update()
    {
        if (cam == null)
            cam = FindObjectOfType<Camera>(); //GameObject.FindGameObjectWithTag("NameTag").GetComponent<Camera>();

        if (cam == null)
            return;

        transform.LookAt(cam.transform);
        transform.Rotate(Vector3.up);
    }
}

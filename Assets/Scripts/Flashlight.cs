using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Flashlight : MonoBehaviour
{
    [Header("Flaslight")]
    public Light flashLight;

    [Header("Flashlight Audio")]
    public AudioSource[] audioSources;
    public AudioSource flashOn;
    public AudioSource flashOff;

    PhotonView PV;

    // Start is called before the first frame update
    public void Start()
    {
        //flashLight.enabled = false;
    }

    public void Awake()
    {
        PV = this.transform.GetComponent<PhotonView>();

        if (PV.IsMine)
        {
            flashLight = this.transform.Find("Camera_Pivot/FlashlightHolder").GetComponentInChildren<Light>();
            Debug.Log(flashLight.name);

            audioSources = this.transform.Find("Camera_Pivot/FlashlightHolder").GetComponents<AudioSource>();
            Debug.Log(audioSources[0].gameObject.name);
            Debug.Log(audioSources[1].gameObject.name);

            flashOn = audioSources[0];
            flashOff = audioSources[1];

            flashOn.spatialBlend = 0.5f;
            flashOff.spatialBlend = 0.5f;
        }
        else
        {
            flashOn.spatialBlend = 1f;
            flashOff.spatialBlend = 1f;
        }
    }

    // Update is called once per frame
    public void Update()
    {
        if (PV.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.F) && flashLight.enabled == false)
            {
                PV.RPC("UseFlashlightOn", RpcTarget.All);
            }

            if (Input.GetKeyDown(KeyCode.F) && flashLight.enabled == true)
            {
                PV.RPC("UseFlashlightOff", RpcTarget.All);
            }
        }
    }

    [PunRPC]
    public void UseFlashlightOn()
    {
        StartCoroutine(Coroutine_UseFlashlightOn());
    }

    IEnumerator Coroutine_UseFlashlightOn()
    {
        flashOn.Play();
        yield return new WaitForSeconds(0.2f);
        flashLight.enabled = true;
    }

    [PunRPC]
    public void UseFlashlightOff()
    {
        StartCoroutine(Coroutine_UseFlashlightOff());
    }

    IEnumerator Coroutine_UseFlashlightOff()
    {
        flashOff.Play();
        yield return new WaitForSeconds(0.2f);
        flashLight.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTestCode : MonoBehaviour
{
    public AudioListener audioListener;

    [SerializeField] AudioSource audioSource1;
    [SerializeField] AudioSource audioSource2;
    [SerializeField] AudioSource audioSource3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector2.Distance(audioSource1.transform.position, this.transform.position));
        
    }

    public void damage()
    {
       
    }


}

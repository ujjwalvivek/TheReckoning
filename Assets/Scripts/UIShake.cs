using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIShake : MonoBehaviour
{
    public CanvasRenderer healthBar;
    public float duration = 0.5f;
    private float shake;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int shakeAmount = 30;

        shake = Mathf.PingPong(Time.time, duration) / duration;

        float shareOffset = Mathf.Lerp(0, shakeAmount, shake);
    }
}

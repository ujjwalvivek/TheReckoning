using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [Header("Rotation Speed")]
    [SerializeField]
    public float speed = 0f;

    [Header("Forward Direction")]
    [Space(20)]
    [SerializeField] public bool ForwardX = false;
    [SerializeField] public bool ForwardY = false;
    [SerializeField] public bool ForwardZ = false;
    

    [Header("Reverse Direction")]
    [Space(20)]
    [SerializeField] public bool ReverseX = false;
    [SerializeField] public bool ReverseY = false;
    [SerializeField] public bool ReverseZ = false;

    void Update()
    {
        //Forward Direction
        if (ForwardX == true)
        {
            transform.Rotate(Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if (ForwardY == true)
        {
            transform.Rotate(0, Time.deltaTime * speed, 0, Space.Self);
        }
        if (ForwardZ == true)
        {
            transform.Rotate(0, 0, Time.deltaTime * speed, Space.Self);
        }
        //Reverse Direction
        if (ReverseX == true)
        {
            transform.Rotate(-Time.deltaTime * speed, 0, 0, Space.Self);
        }
        if (ReverseY == true)
        {
            transform.Rotate(0, -Time.deltaTime * speed, 0, Space.Self);
        }
        if (ReverseZ == true)
        {
            transform.Rotate(0, 0, -Time.deltaTime * speed, Space.Self);
        }

    }
}

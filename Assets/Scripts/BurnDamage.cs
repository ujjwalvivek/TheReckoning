using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using ECM.Controllers;

public class BurnDamage : MonoBehaviour
{
    //PhotonViews
    PhotonView PV;

    //Damage Inflicted
    public float damage;

    //Health Script
    protected Health health;

    //Tick and Delay
    private float currentTime = 0f;
    public float tickRate;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PV = other.gameObject.GetComponent<PhotonView>();

            if (PV.IsMine)
            {
                health = other.gameObject.GetComponent<Health>();

                Debug.Log("Started taking damage");

                if (health.currentHealth >= 0)
                {
                    if (currentTime <= 0)
                    {
                        currentTime = tickRate;
                        StartCoroutine(DamageOverTimeCoroutine(damage, tickRate, other));
                    }
                    else
                    {
                        currentTime -= Time.deltaTime;
                    }
                }
            }
        }
    }

    IEnumerator DamageOverTimeCoroutine(float damageAmount, float duration, Collider other)
    {
        yield return new WaitForSeconds(duration);
        other.gameObject.GetComponent<IDamageable>()?.TakeDamage(damageAmount);
    }
}

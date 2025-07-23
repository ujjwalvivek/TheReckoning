using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using ECM.Controllers;
using Photon.Realtime;

public class NameTag : MonoBehaviourPun
{
    public TMP_Text nameText;
    public Image healthBarImage;
    public Canvas nameTag;

    private PhotonView PV;
    protected Health healthScript;

    [SerializeField]
    public float health = 100f;

    private void Awake()
    {
        PV = this.GetComponent<PhotonView>();
        healthScript = this.GetComponent<Health>();
    }

    private void Start()
    {
        if (PV.IsMine) 
        {
            SetNameOwner();
            nameTag.gameObject.SetActive(false);
        }
        else
        {
            SetNameOther();
        }
    }

    public void SetNameOwner()
    {
        nameText.text = PhotonNetwork.NickName;
    }

    public void SetNameOther()
    {
        nameText.text = PV.Owner.NickName;
    }

    private void Update()
    {
        PV.RPC("ModifyFill", RpcTarget.All, healthScript.currentHealth);
    }

    [PunRPC]
    public void ModifyFill(float currentHealth)
    {
        SetImageFill(currentHealth);
    }

    public void SetImageFill(float amount)
    {
        if (PV.IsMine)
        {
            healthBarImage.fillAmount = amount / health;

            if (healthBarImage.fillAmount <= 0.3f)
            {
                healthBarImage.color = new Color32(237, 76, 103, 100);
            }
            else
            {
                healthBarImage.color = Color.white;
            }
        }
        else
        {
            healthBarImage.fillAmount = amount / health;

            if (healthBarImage.fillAmount <= 0.3f)
            {
                healthBarImage.color = new Color32(237, 76, 103, 100);
            }
            else
            {
                healthBarImage.color = Color.white;
            }
        }
    }
}

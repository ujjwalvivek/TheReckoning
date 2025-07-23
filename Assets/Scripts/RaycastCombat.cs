using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class RaycastCombat : MonoBehaviour
{
    //PhotonView
        //Player's PhotonView
            PhotonView PV1; 
        //Weapon's PhotonView
            PhotonView PV2;

    //ItemManager Script
        ItemManager weapon;

    //AttackPoint
        public Transform attackPoint;

    //Gun stats
        public int damage;
        public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
        public int magazineSize, bulletsPerTap;
        public bool allowButtonHold;
        private int bulletsLeft, bulletsShot;

    //bools 
        bool shooting, readyToShoot, reloading;

    //Reference
        public GameObject fpsCam;
        public LayerMask player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        PV1 = GetComponent<PhotonView>();
        weapon = GetComponent<ItemManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    float timeSinceLastShot;
    [Header("References")]
    [SerializeField] GunData gunData;

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);
    
    public void Shoot()
    {
        if (gunData.currentAmmo > 0)
        {

        }
    }
}

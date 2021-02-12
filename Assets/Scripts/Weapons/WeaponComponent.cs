using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Weapons
{
    [Serializable]
    public struct WeaponStats
    {
        public string Name;
        public float Damage;
        public float BulletsInClip;
        public int ClipSize;
        public int TotalBulletsAvailable;

        public float FireStartDelay;
        public float FireRate;
        public float FireDistance;
        public bool Repeating;

        public LayerMask WeaponHitLayer;
    }

    public class WeaponComponent : MonoBehaviour
    {
        public Transform HandPosition => GripIKLocation;
        [SerializeField] Transform GripIKLocation;

        public bool Firing { get; private set; } = false;
        public bool Reloading { get; private set; } = false;

        public WeaponStats WeaponStats;

        protected WeaponHolder WeaponHolder;
        protected CrosshairScript Crosshair;

        public void Initialize(WeaponHolder weaponHolder, CrosshairScript crosshair)
        {
            WeaponHolder = weaponHolder;
            Crosshair = crosshair;
        }

        public virtual void StartFiring()
        {
            Firing = true;
            if (WeaponStats.Repeating)
            {
                InvokeRepeating(nameof(FireWeapon), WeaponStats.FireStartDelay, WeaponStats.FireRate);
            }
            else
            {
                FireWeapon();
            }
        }

        public virtual void StopFiring()
        {
            Firing = false;
            CancelInvoke(nameof(FireWeapon));
        }

        protected virtual void FireWeapon()
        {

        }

        public void StartReloading()
        {
            Reloading = true;
            ReloadWeapon();
        }

        public void StopReloading()
        {
            Reloading = false;
        }

        private void ReloadWeapon()
        {
            int bulletToReload = WeaponStats.TotalBulletsAvailable - WeaponStats.ClipSize;
            if (bulletToReload < 0)
            {
                WeaponStats.BulletsInClip += WeaponStats.TotalBulletsAvailable;
                WeaponStats.TotalBulletsAvailable = 0;
            }
            else
            {
                WeaponStats.BulletsInClip = WeaponStats.ClipSize;
                WeaponStats.TotalBulletsAvailable -= WeaponStats.ClipSize;
            }
        }
    }
}

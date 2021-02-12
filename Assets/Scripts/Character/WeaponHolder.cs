using System.Collections;
using System.Collections.Generic;
using Character;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Weapons
{
    public class WeaponHolder : MonoBehaviour
    {
        [SerializeField] private GameObject Weapon;
        [SerializeField] private Transform WeaponSocket;

        private Transform GripLocation;

        private PlayerController PlayerController;
        private Animator PlayerAnimator;

        // Ref
        private Camera MainCamera;
        private WeaponComponent EquippedWeapon;

        // Animator Hashes
        private readonly int AimVerticalHash = Animator.StringToHash("AimVertical");
        private readonly int AimHorizontalHash = Animator.StringToHash("AimHorizontal");
        private readonly int IsFiringHash = Animator.StringToHash("IsFiring");
        private readonly int IsReloadingHash = Animator.StringToHash("IsReloading");

        private void Awake()
        {
            PlayerController = GetComponent<PlayerController>();
            PlayerAnimator = GetComponent<Animator>();

            MainCamera = Camera.main;
        }

        // Start is called before the first frame update
        void Start()
        {
            GameObject spawnedWeapon = Instantiate(Weapon, WeaponSocket.position, WeaponSocket.rotation);

            if (!spawnedWeapon) return;

            spawnedWeapon.transform.parent = WeaponSocket;
            EquippedWeapon = spawnedWeapon.GetComponent<WeaponComponent>();
            GripLocation = EquippedWeapon.HandPosition;

            EquippedWeapon.Initialize(this, PlayerController.CrosshairComponent);
            PlayerEvents.Invoke_OnWeaponEquipped(EquippedWeapon);
        }

        public void OnLook(InputValue delta)
        {
            Vector3 independentMousePosition =
                MainCamera.ScreenToViewportPoint(PlayerController.CrosshairComponent.CurrentMousePosition);

            PlayerAnimator.SetFloat(AimVerticalHash, independentMousePosition.y);
            PlayerAnimator.SetFloat(AimHorizontalHash, independentMousePosition.x);
        }

        public void OnFire(InputValue button)
        {
            if (button.isPressed)
            {
                PlayerController.isFiring = true;
                EquippedWeapon.StartFiring();
            }
            else
            {
                PlayerController.isFiring = false;
                EquippedWeapon.StopFiring();
            }

            PlayerAnimator.SetBool(IsFiringHash, PlayerController.isFiring);
        }

        public void OnReload(InputValue button)
        {
            StartReloading();
        }

        public void StartReloading()
        {
            PlayerController.isReloading = true;
            PlayerAnimator.SetBool(IsReloadingHash, PlayerController.isReloading);
            EquippedWeapon.StartReloading();

            InvokeRepeating(nameof(StopReloading), 0, 0.1f);
        }

        public void StopReloading()
        {
            if (PlayerAnimator.GetBool(IsReloadingHash)) return;

            PlayerController.isReloading = false;
            EquippedWeapon.StopReloading();

            CancelInvoke(nameof(StopReloading));
        }

        private void OnAnimatorIK(int layerIndex)
        {
            PlayerAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);
            PlayerAnimator.SetIKPosition(AvatarIKGoal.LeftHand, GripLocation.position);
        }

    }
}
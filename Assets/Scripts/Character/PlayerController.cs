using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Weapons;

namespace Character
{
    public class PlayerController : MonoBehaviour, IPausable
    {
        public CrosshairScript CrosshairComponent => CrosshairScript;
        [SerializeField] private CrosshairScript CrosshairScript;

        private GameUIController GameUIController;

        public HealthComponent Health => HealthComponent;
        private HealthComponent HealthComponent;

        public InventoryComponent Inventory => InventoryComponent; 
        private InventoryComponent InventoryComponent;

        public WeaponHolder WeaponHolder => WeaponHolderComponent;
        private WeaponHolder WeaponHolderComponent;

        private PlayerInput PlayerInput;

        [SerializeField] ConsumableScriptable Consume;

        public bool isFiring;
        public bool isReloading;
        public bool isJumping;
        public bool isRunning;
        public bool inInventory;

        private void Awake()
        {
            if (GameUIController == null) GameUIController = FindObjectOfType<GameUIController>();
            if (PlayerInput == null) PlayerInput = GetComponent<PlayerInput>();
            if (WeaponHolderComponent == null) WeaponHolderComponent = GetComponent<WeaponHolder>();
            if (HealthComponent == null) HealthComponent = GetComponent<HealthComponent>();
            if (InventoryComponent == null) InventoryComponent = GetComponent<InventoryComponent>();
        }

        private void Start()
        {
            Health.TakeDamage(50);
            //Consume.UseItem(this);
        }

        public void OnPauseGame()
        {
            PauseManager.Instance.PauseGame();
        }

        public void OnUnpauseGame()
        {
            PauseManager.Instance.UnpauseGame();
        }

        public void PauseGame()
        {
            GameUIController.EnablePauseMenu();
            if (PlayerInput)
            {
                PlayerInput.SwitchCurrentActionMap("PauseActionMap");
            }
        }

        public void UnpauseGame()
        {
            GameUIController.EnableGameMenu();
            if (PlayerInput)
            {
                PlayerInput.SwitchCurrentActionMap("ThirdPerson");
            }
        }

        public void OnInventory(InputValue button)
        {
            if (inInventory)
            {
                inInventory = false;
                OpenInventory(false);
            }
            else
            {
                inInventory = true;
                OpenInventory(true);
            }
        }

        private void OpenInventory(bool open)
        {
            if (open)
            {
                PauseManager.Instance.PauseGame();
                GameUIController.EnableInventoryMenu();
            }
            else
            {
                PauseManager.Instance.UnpauseGame();
                GameUIController.EnableGameMenu();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    public class PlayerController : MonoBehaviour
    {
        public CrosshairScript CrosshairComponent => CrosshairScript;
        [SerializeField] private CrosshairScript CrosshairScript;

        public bool isFiring;
        public bool isReloading;
        public bool isJumping;
        public bool isRunning;
    }
}

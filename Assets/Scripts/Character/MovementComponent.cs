using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Character
{
    public class MovementComponent : MonoBehaviour
    {
        [SerializeField] private float WalkSpeed;
        [SerializeField] private float RunSpeed;
        [SerializeField] private float JumpForce;

        private GameInputActions InputActions;

        //Comp
        private Animator PlayerAnimator;
        private PlayerController PlayerController;
        private Rigidbody PlayerRigidbody;

        private Vector2 InputVector = Vector2.zero;
        private Vector3 MoveDirection = Vector3.zero;

        // Animator hashes
        private readonly int MovementXHash = Animator.StringToHash("MovementX");
        private readonly int MovementZHash = Animator.StringToHash("MovementZ");
        private readonly int IsRunningHash = Animator.StringToHash("IsRunning");
        private readonly int IsJumpingHash = Animator.StringToHash("IsJumping");

        private void Awake()
        {
            PlayerController = GetComponent<PlayerController>();
            PlayerAnimator = GetComponent<Animator>();
            PlayerRigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (PlayerController.isJumping) return;
            if (!(InputVector.magnitude > 0)) MoveDirection = Vector3.zero;

            MoveDirection = transform.forward * InputVector.y + transform.right * InputVector.x;

            float currentSpeed = PlayerController.isRunning ? RunSpeed : WalkSpeed;

            Vector3 movementDirection = MoveDirection * (currentSpeed * Time.deltaTime);

            transform.position += movementDirection;
        } 

        public void OnMovement(InputValue value)
        {
            InputVector = value.Get<Vector2>();

            PlayerAnimator.SetFloat(MovementXHash, InputVector.x);
            PlayerAnimator.SetFloat(MovementZHash, InputVector.y);
        }

        public void OnRun(InputValue button)
        {
            PlayerController.isRunning = button.isPressed;
            PlayerAnimator.SetBool(IsRunningHash, button.isPressed);
        }

        public void OnJump(InputValue button)
        {
            PlayerController.isJumping = true;
            PlayerAnimator.SetBool(IsJumpingHash, true);

            PlayerRigidbody.AddForce((transform.up + MoveDirection) * JumpForce, ForceMode.Impulse);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (!other.gameObject.CompareTag("Ground") && !PlayerController.isJumping) return;

            PlayerController.isJumping = false;
            PlayerAnimator.SetBool(IsJumpingHash, false);
        }
    }
}
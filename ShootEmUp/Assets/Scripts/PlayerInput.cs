//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

namespace ShootEmUp
{
    [RequireComponent(typeof(CharacterMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerActionControls playerActionControls;
        private CharacterMovement characterMovement;

        private void Awake()
        {
            playerActionControls = new PlayerActionControls();
            characterMovement = GetComponent<CharacterMovement>();
        }

        private void OnEnable()
        {
            playerActionControls.Enable();
        }

        private void OnDisable()
        {
            playerActionControls.Disable();
        }

        private void Update()
        {
            characterMovement.movementInput = playerActionControls.Basic.Move.ReadValue<Vector2>();
        }
    }
}


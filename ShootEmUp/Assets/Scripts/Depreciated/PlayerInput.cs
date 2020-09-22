//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

namespace ShootEmUp
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        private PlayerActionControls playerActionControls;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerActionControls = new PlayerActionControls();
            playerMovement = GetComponent<PlayerMovement>();
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
            //characterMovement.movementInput = playerActionControls.Basic.Move.ReadValue<Vector2>();
        }
    }
}


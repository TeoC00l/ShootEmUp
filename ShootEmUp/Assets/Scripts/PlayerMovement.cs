//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.InputSystem;

namespace ShootEmUp
{
    public class PlayerMovement : MonoBehaviour
    {
        [System.NonSerialized] public Vector2 movementInput = default;        
        [SerializeField] private float speed = 10f;
        private Transform playerTransform;
        private Vector3 movementDirection = Vector2.zero;

        private void Awake()
        {           
            playerTransform = transform;
        }

        private void Update()
        {
            playerTransform.position += movementDirection * (speed *Time.deltaTime);
        }

        public void OnMove(InputValue value)
        {
            movementDirection = value.Get<Vector2>();
        }
    }
}

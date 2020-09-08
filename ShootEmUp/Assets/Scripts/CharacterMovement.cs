//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System;
using UnityEngine;

namespace ShootEmUp
{
    [RequireComponent(typeof(PlayerInput))]
    public class CharacterMovement : MonoBehaviour
    {
        [NonSerialized] public Vector2 movementInput = default;
        [SerializeField] private float speed = 10f;
        private Transform playerTransform;

        private void Awake()
        {
            playerTransform = transform;
        }

        private void Update()
        {
            playerTransform.position += (Vector3) movementInput * (speed * Time.deltaTime);
        }
    }
}

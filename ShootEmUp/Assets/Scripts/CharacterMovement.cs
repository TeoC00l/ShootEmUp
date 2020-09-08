//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using System.Transactions;
using UnityEngine;

namespace ShootEmUp
{
    [RequireComponent(typeof(PlayerInput))]
    public class CharacterMovement : MonoBehaviour
    {
        public Vector2 movementInput = default;
        [SerializeField] private float speed = 10f;
            
        private void Update()
        {
            transform.position += (Vector3) movementInput * (speed * Time.deltaTime);
        }
    }
}

//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [System.NonSerialized] public Vector2 movementInput = default;        
    [SerializeField] private float speed = 10f;
    private Transform playerTransform;
    private Vector3 movementDirection = Vector2.zero;

    private float cameraHorizontalHalfExtent;
    private float cameraVerticalHalfExtent;

    private CircleCollider2D characterCollider;

    private int screenWidth;
    private int screenHeight;

    private void Awake()
    {           
        playerTransform = transform;
        characterCollider = GetComponent<CircleCollider2D>();
        cameraVerticalHalfExtent = Camera.main.orthographicSize;
        screenWidth = Screen.width;
        screenHeight = Screen.height;
    }

    private void Update()
    {
        Vector2 newPosition = playerTransform.position += movementDirection * (speed *Time.deltaTime);
        playerTransform.position = ClampPositionToCameraView(newPosition);

    }

    public void OnMove(InputValue value)
    {
        movementDirection = value.Get<Vector2>();
    }

        private Vector2 ClampPositionToCameraView(Vector2 position)
        {
            cameraHorizontalHalfExtent = cameraVerticalHalfExtent * screenWidth / screenHeight;
            
            float characterOffset = characterCollider.bounds.size.x /2;

            float newPositionX = Mathf.Clamp(position.x, -cameraHorizontalHalfExtent + characterOffset, cameraHorizontalHalfExtent - characterOffset);
            float newPositionY = Mathf.Clamp(position.y, -cameraVerticalHalfExtent + characterOffset, cameraVerticalHalfExtent - characterOffset);

            return new Vector2(newPositionX, newPositionY);
        }
}


//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using Random = UnityEngine.Random;

public class SineEnemyMovement : MonoBehaviour, IEnemyMovement
{
    private readonly Vector3[] strafeDirections = {Vector3.zero, Vector3.left, Vector3.right};
    private Vector3 moveDirection;
    [SerializeField] private float speed = 4f;
    [SerializeField] private float amplitude = 4f;
    [SerializeField] private float frequency = 10f;
    
    private void Awake()
    {
        moveDirection = Vector3.down + strafeDirections[Random.Range(0, strafeDirections.Length)];
    }
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += Mathf.Sin(Time.time * frequency) * amplitude * Time.deltaTime;
        transform.position = newPosition + moveDirection * (speed * Time.deltaTime);
    }
}

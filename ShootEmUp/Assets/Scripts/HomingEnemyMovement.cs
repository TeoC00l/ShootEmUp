//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using UnityEngine.Assertions;

public class HomingEnemyMovement : MonoBehaviour, IEnemyMovement
{
    [SerializeField] private float speed = 6f;
    
    private Transform playerTransform;
    private Transform objectTransform;

    private void Awake()
    {
        playerTransform = GameManager.Instance.player.transform;
        objectTransform = transform;
    }
    private void FixedUpdate()
    {
        Move();
    }
    
    public void Move()
    {
        transform.position = Vector2.MoveTowards(objectTransform.position, playerTransform.position, speed*Time.deltaTime);
    }
}

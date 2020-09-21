//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;
using Random = UnityEngine.Random;
public class Enemy : MonoBehaviour
{
    private Vector3[] strafe = {Vector3.zero, Vector3.left, Vector3.right};
    private Vector3 moveDirection;
    private float speed = 4f;
    private float amplitude = 4f;
    private float frequency = 10f;

    private void Awake()
    {
        moveDirection = Vector3.down + strafe[Random.Range(0, strafe.Length)];
    }
    private void Update()
    {
        Vector3 _newPosition = transform.position;
        _newPosition.y += Mathf.Sin(Time.time * frequency) * amplitude * Time.deltaTime;
        transform.position = _newPosition + moveDirection * (speed * Time.deltaTime);
    }
}

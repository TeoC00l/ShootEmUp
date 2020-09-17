//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.down + Vector3.right;
    private float amplitude = 2f;
    private float frequency = 2f;
    private void Update()
    {
        Vector3 _newPosition = transform.position;
        _newPosition.y += Mathf.Sin(Time.time * frequency) * amplitude * Time.deltaTime;
        transform.position = _newPosition + moveDirection * Time.deltaTime;
    }
}

//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class EnemyDeathBehaviour : MonoBehaviour, IDeathBehaviour
{
    public void Die()
    {
        gameObject.SetActive(false);
    }
}

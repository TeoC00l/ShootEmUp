//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class PlayerDeathBehaviour : MonoBehaviour, IDeathBehaviour
{
    public void Die()
    {
        Destroy(gameObject);
    }
}

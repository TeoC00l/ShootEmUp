//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class EnemyDeathBehaviour : IDeathBehaviour
{
    private GameObject gameObject;
    
    public EnemyDeathBehaviour(GameObject gameObject)
    {
        this.gameObject = gameObject;
    }
    
    public void Die()
    {
        gameObject.SetActive(false);
    }
}

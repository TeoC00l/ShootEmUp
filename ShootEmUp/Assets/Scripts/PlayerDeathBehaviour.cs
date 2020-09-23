//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class PlayerDeathBehaviour : IDeathBehaviour
{
    private GameObject player;
    
    public PlayerDeathBehaviour(GameObject player)
    {
        this.player = player;
    }
    
    public void Die()
    {
        // TODO: Change so that nothing is passed in constructor, and GameOver() exists in game manager
        player.SetActive(false);
    }
}

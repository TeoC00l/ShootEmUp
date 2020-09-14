//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data", menuName = "Bullet")]
public class BulletData : ScriptableObject
{
    public float speed = 10f;
    public float damage = 5f;
    public ParticleSystem onHitEffect;
}

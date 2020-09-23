//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet Data", menuName = "Bullet")]
public class BulletData : ScriptableObject
{
    public float speed = 10f;
    public float lifeTime = 0.5f;
    public int damage = 5;
    public ParticleSystem onHitEffect;
}

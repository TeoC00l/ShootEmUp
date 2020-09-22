//@Author: Teodor Tysklind / FutureGames / Teodor.Tysklind@FutureGames.nu

using UnityEngine;

public class DamageableData : ScriptableObject
{
    public int maxHitPoints;
    public AudioClip onDeathAudioClip;
    public ParticleSystem onDeathParticle;
}

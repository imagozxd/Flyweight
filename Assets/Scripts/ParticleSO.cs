using UnityEngine;

[CreateAssetMenu(fileName = "NewParticleType", menuName = "Particles/ParticleType")]
public class ParticleSO : ScriptableObject
{
    public Material material;
    public Color color;
    public float speed;
    public float lifetime;
}

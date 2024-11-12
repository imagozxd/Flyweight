using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFactorySO : MonoBehaviour
{
    private static List<ParticleSO> particleTypes = new List<ParticleSO>();

    public static ParticleSO GetParticle(Material material, Color color, float speed, float lifetime)
    {
        foreach (var type in particleTypes)
        {
            if (type.material == material && type.color == color &&
                Mathf.Abs(type.speed - speed) < 0.001f &&
                Mathf.Abs(type.lifetime - lifetime) < 0.001f)
            {
                return type;
            }
        }

        var newType = ScriptableObject.CreateInstance<ParticleSO>();
        newType.material = material;
        newType.color = color;
        newType.speed = speed;
        newType.lifetime = lifetime;

        particleTypes.Add(newType);
        return newType;
    }
}


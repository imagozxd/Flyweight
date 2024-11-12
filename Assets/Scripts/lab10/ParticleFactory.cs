using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ParticleFactory : MonoBehaviour
{
    private static List<FakeParticle> fakeParticles = new List<FakeParticle>();
    public static FakeParticle GetParticleType(Material material, Color color, float speed, float lifetime)
    {
        foreach (var type in fakeParticles)
        {
            if (type.material == material && type.color == color &&
                Math.Abs(type.speed - speed) < 0.001f &&
                Math.Abs(type.lifeTime - lifetime) < 0.001f)
            {
                return type;
            }
        }

        var newType = new FakeParticle(material, color, speed, lifetime);
        fakeParticles.Add(newType);
        return newType;
    }


}

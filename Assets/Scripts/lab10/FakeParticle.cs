using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeParticle
{
    public Material material;
    public Color color;
    public readonly float speed;
    public readonly float lifeTime;

    public FakeParticle(Material material, Color color, float speed, float lifeTime)
    {   
        this.material = material;
        this.color = color;
        this.speed = speed;
        this.lifeTime = lifeTime;      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest1 : MonoBehaviour
{
    public Material testMaterial;
    public Color testColor = Color.red;
    public float testSpeed = 1.0f;
    public float testLifeTime = 5.0f;
    public int particleCount = 1000; 

    private List<FakeParticle> particleInstances = new List<FakeParticle>();

    private void Start()
    {
        TestParticles();
    }

    private void TestParticles()
    {
        for (int i = 0; i < particleCount; i++)
        {
            FakeParticle fakeParticle = ParticleFactory.GetParticleType(testMaterial, testColor, testSpeed, testLifeTime);
            particleInstances.Add(fakeParticle);
        }

        Debug.Log(particleCount + " particles");
    }
}

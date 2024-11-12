using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTest2 : MonoBehaviour
{
    public ParticleSO particleType;
    //public Material testMaterial;
    //public Color testColor = Color.red;
    //public float testSpeed = 1.0f;
    //public float testLifeTime = 5.0f;
    public int particleCount = 1000;

    private List<ParticleSO> particleInstances = new List<ParticleSO>();

    private void Start()
    {
        TestParticles();
    }

    private void TestParticles()
    {
        for (int i = 0; i < particleCount; i++)
        {
            particleInstances.Add(particleType);
        }

        Debug.Log(particleCount + " particles SO");
    }
}

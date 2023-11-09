using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleStart : MonoBehaviour
{
    [SerializeField] ParticleSystem[] particles;

    private void Start()
    {
        
    }

    public void StartParticles()
    {
        foreach (ParticleSystem flowers in particles)
            flowers.Play();
    }
}

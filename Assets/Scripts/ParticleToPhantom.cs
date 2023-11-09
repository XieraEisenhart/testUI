using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParticleToPhantom : MonoBehaviour
{
    [SerializeField] ParticleSystem[] particles;
    [SerializeField] Material ghosts;
    [SerializeField] TextMeshProUGUI buttonText;

    public void OnClickChange()
    {
        foreach (ParticleSystem flowers in particles)
            flowers.gameObject.GetComponent<ParticleSystemRenderer>().material = ghosts;

        buttonText.SetText("BOO");
    }
}

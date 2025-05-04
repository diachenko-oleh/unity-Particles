using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Sword : MonoBehaviour
{
    public KeyCode ToggleKey = KeyCode.Space;

    public ParticleSystem particleSystem;
    public GameObject PointLight;

    bool IsPlaying = true;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(ToggleKey))
        {
            if (IsPlaying)
            {
                particleSystem.Stop();
                PointLight.SetActive(false);
                IsPlaying = false;
            }
            else
            {
                particleSystem.Play();
                PointLight.SetActive(true);
                IsPlaying = true;
            }
        }
    }
}

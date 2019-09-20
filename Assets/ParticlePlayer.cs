using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{

    ParticleSystem system;

    // Start is called before the first frame update
    void Start()
    {
        system = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            system.Play();
        }
    }
}

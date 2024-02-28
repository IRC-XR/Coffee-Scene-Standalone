using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkPouringScript : MonoBehaviour
{
    // https://www.youtube.com/watch?v=SYHYDeLt6BM

    ParticleSystem particles;
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Angle: " + Vector3.Angle(Vector3.down, transform.forward));
        if (Vector3.Angle(Vector3.down, transform.forward) <= 45f)
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }
}

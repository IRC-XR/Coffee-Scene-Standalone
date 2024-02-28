using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PouringScript : MonoBehaviour
{
    // https://www.youtube.com/watch?v=SYHYDeLt6BM

    ArrayList already_added = new ArrayList();
    public GameObject cof;
    ParticleSystem particles;
    List<ParticleSystem.Particle> inside = new List<ParticleSystem.Particle>();

    CoffeeScoreScript cf;


    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Angle: " + Vector3.Angle(Vector3.down, transform.forward));
        if(Vector3.Angle(Vector3.down, transform.forward) <= 45f)
        {
            particles.Play();
        }
        else
        {
            particles.Stop();
        }
    }

    void OnParticleTrigger()
    {
        Debug.Log("HITTERS HIT!");
        GameObject g = GameObject.Find("MetalMug");
        cf = g.GetComponent<CoffeeScoreScript>();
        ParticleSystem ps = GetComponent<ParticleSystem>();
        int numInside = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Inside, inside);
        Debug.Log("NUM " + numInside);
        if (!already_added.Contains(ps.trigger.GetCollider(0)))
        {
            if (numInside > 300)
            {
                cf.cof.transform.position = new Vector3(cf.cof.transform.position.x, cf.cof.transform.position.y + 0.015f, cf.cof.transform.position.z);
                cf.addPoints();
                cf.displayScore();
                already_added.Add(ps.trigger.GetCollider(0));
            }
        }
/*        if (!already_added.Contains(ps.gameObject))
        {
            if (ps.gameObject.CompareTag(cf.getTag()))
            {
                Debug.Log("Bye");
                if (ps.gameObject.name.Contains("Milk"))
                {
                    already_added.Add("Milk");
                    cf.addPoints();
                    //cf.cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.015f, transform.position.z);
                    cf.displayScore();
                }
                if (ps.gameObject.name.Contains("Coffee"))
                {
                    already_added.Add("Coffee");
                    cf.addPoints();
                    //cf.cof.transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
                    Debug.Log("Points added coffee");
                    cf.displayScore();

                }
            }
        }*/
    }

}

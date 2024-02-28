using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using TMPro;


public class RABoxScript : MonoBehaviour
{

    List<Collider> collided = new List<Collider>();
    List<string> tags_collided = new List<string>();
    PillSortingRAScript ps;
    public GameObject pb;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        ps = pb.GetComponent<PillSortingRAScript>();

        if (!tags_collided.Contains(other.tag))
        {
            if (!collided.Contains(other))
            {
                collided.Add(other);
                tags_collided.Add(other.tag);
                if (other.name.Contains("Pill"))
                {
                    ps.addPoints();
                    ps.displayScore();
                }
            }
        }
    }

}

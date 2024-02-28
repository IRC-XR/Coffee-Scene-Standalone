using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJointScript : MonoBehaviour
{
    bool jointCreated = false;
    public GameObject tp;
    public GameObject cap;
    public GameObject tpholder;
    HygieneScoreScript hs;
    // Start is called before the first frame update
    void Start()
    {
        jointCreated = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

/*    void getCapOrientation()
    {
        Debug.Log("Cap Rotation: " + gameObject.transform.rotation.eulerAngles.z)
        Debug.Lod("Cap Distance: " + gameObject.transform.position.eulerAngles.x)
    }
*/
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "toothpasteTubeWOcap")
        {
            hs = tpholder.GetComponent<HygieneScoreScript>();
            Debug.Log("Collision Broken: " + collision.gameObject.name);
            tp.SetActive(true);
            Destroy(GetComponent<FixedJoint>());
            hs.addPoints();
            cap.SetActive(false);
            hs.displayScore();
            // gameObject.GetComponent<FixedJoint>().connectedBody = collision.gameObject.rigidbody;
            //jointCreated = true;
            //}
        }
    }

}

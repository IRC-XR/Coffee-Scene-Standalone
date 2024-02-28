using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/** https://learn.unity.com/tutorial/creating-a-vr-menu-2019-2 */

public class LineRendererSettings : MonoBehaviour
{

    [SerializeField] LineRenderer r;
    public GameObject panel;
    public Image img;
    public Button btn;

    Vector3[] points;
    // Start is called before the first frame update
    void Start()
    {

        r = gameObject.GetComponent<LineRenderer>();

        points = new Vector3[2];

        points[0] = Vector3.zero;

        points[1] = transform.position + new Vector3(0, 0, 20);

        r.SetPositions(points);
        r.enabled = true;

        img = panel.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        AlignRenderer(r);
        if (AlignRenderer(r) && Input.GetAxis("Submit") > 0)
        {
            btn.onClick.Invoke();
        }
    }


    public LayerMask lm;

    public bool AlignRenderer(LineRenderer lr)
    {
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit rch;
        bool btnClick = false;

        if(Physics.Raycast(ray, out rch, lm))
        {
            points[1] = transform.forward + new Vector3(0, 0, rch.distance);
            lr.startColor = Color.red;
            lr.endColor = Color.red;
            btn = rch.collider.gameObject.GetComponent<Button>();
            btnClick = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 20);
            lr.startColor = Color.green;
            lr.endColor = Color.green;
            btnClick = false;
        }

        lr.SetPositions(points);
        lr.material.color = lr.startColor;
        return btnClick;
    }

    public void ColorChange()
    {
        if (btn != null)
        {
            if (btn.name == "abt_disorders_btn")
            {
                img.color = Color.red;
            }
            else if (btn.name == "tutorial_btn")
            {
                img.color = Color.blue;
            }
            else if (btn.name == "start_btn")
            {
                img.color = Color.green;
            }
        }
    }
}

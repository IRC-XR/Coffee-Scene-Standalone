using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=OBnCd1bzCcw
    public GameObject liquid;
    public GameObject liquidMesh;

    private int sloshSpeed = 60;
    private int rotateSpeed = 15;

    private int difference = 25;

    void Update()
    {
        Slosh();

        liquidMesh.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.Self);
    }

   private void Slosh()
    {
        Quaternion iRotation = Quaternion.Inverse(transform.localRotation);

        Vector3 finRotation = Quaternion.RotateTowards(liquid.transform.localRotation, iRotation, sloshSpeed * Time.deltaTime).eulerAngles;

        finRotation.x = ClampRotationValue(finRotation.x, difference);
        finRotation.z = ClampRotationValue(finRotation.z, difference);

        liquid.transform.localEulerAngles = finRotation;
    }

    private float ClampRotationValue(float val, float diff)
    {
        float ret = 0.0f;

        if (val > 180)
        {
            ret = Mathf.Clamp(val, 360 - diff, 360);
        }
        else
        {
            ret = Mathf.Clamp(val, 0, diff);
        }

        return ret;
    }
}

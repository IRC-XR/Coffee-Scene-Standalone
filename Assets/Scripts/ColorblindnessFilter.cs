using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorblindnessFilter : MonoBehaviour
{
    [SerializeField] private PostProcessProfile[] colorblindnessTypeProfiles;
    private int colorblindnessTypeToActivate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateColorblindnessFilter()
    {
        
        GetComponent<PostProcessVolume>().profile = colorblindnessTypeProfiles[colorblindnessTypeToActivate];
        Debug.Log("Made it here: " + GetComponent<PostProcessVolume>().profile);
    }

    public void SetColorblindnessTypeToActivate(int colorblindnessTypeToActivateIn)
    {
        colorblindnessTypeToActivate = colorblindnessTypeToActivateIn;
    }

    void ResetToOriginal()
    {
        GetComponent<PostProcessVolume>().profile = colorblindnessTypeProfiles[0];
    }
}

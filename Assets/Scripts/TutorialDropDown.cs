using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class TutorialDropDown : MonoBehaviour
{
    //https://www.youtube.com/watch?v=URS9A4V_yLc
    public TMP_Text infoBox;
    public VideoClip video_main;
    public VideoPlayer vid;
    public VideoClip cb_vid;
    public VideoClip ra_vid;


    // Start is called before the first frame update
    void Start()
    {
        TMP_Dropdown drop = GetComponent<TMP_Dropdown>();

        drop.ClearOptions();

        List<string> dropdownOptions = new List<string>()
        {
            "Please select a disorder.",
            "Rheumatoid Arthritis",
            "Color Blindness"
        };

        drop.AddOptions(dropdownOptions);

        UpdatedDropDownItem(drop);

        drop.onValueChanged.AddListener(delegate { UpdatedDropDownItem(drop); });
    }


    void UpdatedDropDownItem(TMP_Dropdown dropdown)
    {
        IDictionary<string, string> dropDownInfo = new Dictionary<string, string>();
        dropDownInfo.Add("Please select a disorder.", "Descriptions of how to navigate each disorder will be shown.");
        dropDownInfo.Add("Rheumatoid Arthritis", "You will be presented with three tasks from the scope of someone with RA.\n\nEach task has instructions to assist with completing the activity."
            + "\n\nThe first tasks is a hygiene related task: brushing your teeth.\n\nNext you will be required to open a pill bottle and sort pills.\n\nFinally, you will be required to make a cup of coffee."
            + "\n\nIn order to begin the scene, you must press start on the menu panel.\n\nOnce complete, press done on the menu panel.");
        dropDownInfo.Add("Color Blindness", "You will be presented a task to complete from the scope of someone who is color blind.\n\nYou will begin with completing the task from the perspective of a non-colorblind person."
            + "\n\nThen you will complete it from the perspective of a colorblind person. You are to pick up each pill and drop them in the appropriately labeled box.");

        infoBox.text = dropDownInfo[dropdown.options[dropdown.value].text];


        IDictionary<string, VideoClip> dropDownVid = new Dictionary<string, VideoClip>();
        dropDownVid.Add("Please select a disorder.", video_main);
        dropDownVid.Add("Rheumatoid Arthritis", ra_vid);
        dropDownVid.Add("Color Blindness", cb_vid);

        Debug.Log("---------------");
        Debug.Log("!" + dropDownVid);
        Debug.Log("?" + dropdown.options);
        Debug.Log("][" + dropdown.value);
        
        switch(dropdown.value)
        {
            case 0:
                vid.clip = video_main;
                break;
            case 1:
                vid.clip = ra_vid;
                break;
            case 2:
                vid.clip = cb_vid;
                break;
        }
        //vid.clip = dropDownVid[dropdown.options[dropdown.value]];


    }

}

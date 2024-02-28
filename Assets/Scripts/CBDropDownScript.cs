using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CBDropDownScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=URS9A4V_yLc
    public TMP_Text infoBox;
    public Image imageBox;
    public Sprite cb_i;
    public Sprite p_i;
    public Sprite d_i;
    public Sprite t_i;
    public Sprite pOpia_i;
    public Sprite dOpia_i;
    public Sprite tOpia_i;
    Button start_btn;
    List<string> dropdownOptions;

    // Start is called before the first frame update
    void Start()
    {
        TMP_Dropdown drop = GetComponent<TMP_Dropdown>();

        drop.ClearOptions();

        dropdownOptions = new List<string>()
        {
            "Choose a type.",
            "Protanomaly",
            "Deuteranomaly",
            "Tritanomaly",
            "Protanopia",
            "Deuteranopia",
            "Tritanopia"
        };

        drop.AddOptions(dropdownOptions);

        UpdatedDropDownItem(drop);

        drop.onValueChanged.AddListener(delegate { UpdatedDropDownItem(drop); });
    }


    void UpdatedDropDownItem(TMP_Dropdown dropdown)
    {
        IDictionary<string, string> dropDownInfo = new Dictionary<string, string>();
        dropDownInfo.Add("Choose a type.", "To start, from the dropdown menu, choose the type of colorblindness you would like to work in. An explanation of the type of colorblindness as well as a preview for it will be shown.");
        dropDownInfo.Add("Protanomaly", "\"People with protanomaly have red cones and can perceive some shades of red.\"");
        dropDownInfo.Add("Deuteranomaly", "\"People with deuteranomlay have green cones and can perceive some shades of green. Deuteranomaly is the most common type of colorblindness.\"");
        dropDownInfo.Add("Tritanomaly", "\"People with tritanomaly have blue cones and can perceive some shades of blue.\"");
        dropDownInfo.Add("Protanopia", "\"People with protanopia have no red cones.\"");
        dropDownInfo.Add("Deuteranopia", "\"People with deuteranopia have no green cones.\"");
        dropDownInfo.Add("Tritanopia", "\"People with tritanopia have no blue cones.\"");

        infoBox.text = dropDownInfo[dropdown.options[dropdown.value].text];


        IDictionary<string, Sprite> dropDownImage = new Dictionary<string, Sprite>();
        dropDownImage.Add("Choose a type.", cb_i);
        dropDownImage.Add("Protanomaly", p_i);
        dropDownImage.Add("Deuteranomaly", d_i);
        dropDownImage.Add("Tritanomaly", t_i);
        dropDownImage.Add("Protanopia", pOpia_i);
        dropDownImage.Add("Deuteranopia", dOpia_i);
        dropDownImage.Add("Tritanopia", tOpia_i);


        imageBox.sprite = dropDownImage[dropdown.options[dropdown.value].text];

        GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(dropdownOptions.FindIndex(val => val.Contains(dropdown.options[dropdown.value].text)));
    }

  
    // Update is called once per frame
    void Update()
    {

    }
}

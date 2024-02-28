using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownMenuScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=URS9A4V_yLc
    public TMP_Text infoBox;
    public Image imageBox;
    public Sprite m_i;
    public Sprite r_i;
    public Sprite c_i;

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
        dropDownInfo.Add("Please select a disorder.", "Welcome to Empathy Builder. For more information on a disorder, please select one above.");
        dropDownInfo.Add("Rheumatoid Arthritis", "\"Rheumatoid arthritis, or RA, is an autoimmune and inflammatory disease, which means that your immune system attacks healthy cells in your body by mistake, causing inflammation (painful swelling) in the affected parts of the body. RA mainly attacks the joints, usually many joints at once.\"");
        dropDownInfo.Add("Color Blindness", "\"If you have color blindness, it means you see colors differently than most people. Most of the time, color blindness makes it hard to tell the difference between certain colors. Usually, color blindness runs in families. There is no cure, but special glasses and contact lenses can help. Most people who are color blind are able to adjust and do not have problems with everyday activities. However, some activities can present challenges if they require differentiating objects by color.\"");

        infoBox.text = dropDownInfo[dropdown.options[dropdown.value].text];


        IDictionary<string, Sprite> dropDownImage = new Dictionary<string, Sprite>();
        dropDownImage.Add("Please select a disorder.", m_i);
        dropDownImage.Add("Rheumatoid Arthritis", r_i);
        dropDownImage.Add("Color Blindness", c_i);

        imageBox.sprite = dropDownImage[dropdown.options[dropdown.value].text];


    }

    // Update is called once per frame
    void Update()
    {

    }
}

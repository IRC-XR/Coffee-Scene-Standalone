using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorblindnessTypeMenuManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI colorblindnessTypeExplanation;
    [SerializeField] private Button startButton;
    [SerializeField] private Image colorblindnessTypePreviewImg;
    [SerializeField] private Sprite[] colorblindnessTypePreviewImgs;

    public void updateByChoice(int choice)
    {
        if (choice == 0)
        {
            colorblindnessTypeExplanation.text = "";
            colorblindnessTypePreviewImg.sprite = null;
            startButton.interactable = false;
        }
        else if (choice == 1)
        {
            colorblindnessTypeExplanation.text = "";
            colorblindnessTypePreviewImg.sprite = null;
            startButton.interactable = true;
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(choice - 1);
        }
        else if (choice == 2)
        {
            colorblindnessTypeExplanation.text = "People with protanomaly have red cones and can perceive some shades of red.";
            colorblindnessTypePreviewImg.sprite = colorblindnessTypePreviewImgs[0];
            startButton.interactable = true;
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(choice - 1);
        }
        else if (choice == 3)
        {
            colorblindnessTypeExplanation.text = "People with deuteranomlay have green cones and can perceive some shades of green. Deuteranomaly is the most common type of colorblindness.";
            colorblindnessTypePreviewImg.sprite = colorblindnessTypePreviewImgs[1];
            startButton.interactable = true;
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(choice - 1);
        }
        else
        {
            colorblindnessTypeExplanation.text = "People with tritanomaly have blue cones and can perceive some shades of blue.";
            colorblindnessTypePreviewImg.sprite = colorblindnessTypePreviewImgs[2];
            startButton.interactable = true;
            GameObject.Find("Colorblindness Filter").GetComponent<ColorblindnessFilter>().SetColorblindnessTypeToActivate(choice - 1);
        }
    }
}

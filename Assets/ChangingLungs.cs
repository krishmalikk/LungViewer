using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingLungs : MonoBehaviour
{
    public Text cigarettesText;
    public string changeCigarettesText;
    public GameObject Lung;
    public Material mat;
    public string changeCigarettesText2;
    public Material mat2;


    public void changeLung()
    {   
        if (cigarettesText.text == changeCigarettesText)
        {
            Lung.GetComponent<Renderer>().material = mat;
        }
        if (cigarettesText.text == changeCigarettesText2)
        {
            Lung.GetComponent<Renderer>().material = mat2;
        }
    }
}

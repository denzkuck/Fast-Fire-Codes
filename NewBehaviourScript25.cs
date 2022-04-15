using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript25 : MonoBehaviour
{
    public Text text0;
    void Start()
    {
        float ey = PlayerPrefs.GetFloat("enyüksek");
        text0.text = "BEST RUN TIME : " + ey.ToString("000")+" s";
    }

    
}

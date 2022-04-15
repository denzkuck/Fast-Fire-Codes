using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript21 : MonoBehaviour
{
    public Text text;
    void Start()
    {
        int  enyuksekpuan = PlayerPrefs.GetInt("yuksek");
        text.text = "HIGH SCORE : " + enyuksekpuan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

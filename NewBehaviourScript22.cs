using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript22 : MonoBehaviour
{
    public Text text;
    void Start()
    {
        int puan = PlayerPrefs.GetInt("puan");
        text.text = "SCORE : " + puan;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

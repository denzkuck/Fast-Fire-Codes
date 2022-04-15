using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewBehaviourScript23 : MonoBehaviour
{
   
    public Text texttt;
    
    void Start()
    {
        
        
        float enyuksekpuan = PlayerPrefs.GetFloat("zaman");
        texttt.text = "RUN TIME : "+enyuksekpuan.ToString("000")+" s";
        //texttt.text = "za: " + enyuksekpuan;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

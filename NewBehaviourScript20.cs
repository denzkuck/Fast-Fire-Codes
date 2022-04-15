using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript20 : MonoBehaviour
{

    float timer;
    
    float seconds;
    float minutes;
    [SerializeField] Text Timer;

    void Start()
    {
        timer = 755;
        
    }
  
    public void TimerCalc()
    {
        
        
            timer -= Time.deltaTime;
            
            
            
            Timer.text = timer.ToString("000");
        
 
    }

    void Update()
    {
       
           TimerCalc();
            
    }
    
}

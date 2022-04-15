using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript33 : MonoBehaviour
{
    public float speed = 25f;
    bool slow = true;


    // Start is called before the first frame update
    void Start()
    {
        
            slow = !slow;
            Time.timeScale = slow ? .1f : 1f;
            speed = slow ? speed * 1 / Time.timeScale : 25f;
        
    }
    

}

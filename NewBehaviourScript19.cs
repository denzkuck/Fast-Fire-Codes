using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript19 : MonoBehaviour
{
    
    void Start()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<NewBehaviourScript18>().PlayMusic();

    }

    
    
}

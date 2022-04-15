using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript26 : MonoBehaviour
{

    //public Transform sinir;

    //public NewBehaviourScript2 posx;

    void Start()
    {

        //Transform SinirA = transform.Find("SinirAtes");
        //SinirA.localPosition = new Vector3(0, 0.1000001f, 0);
        

    }

    
    void Update()
    {
        
        //Transform SinirA = transform.Find("SinirAtes");

        //SinirA.localPosition = new Vector3(0, 0.1000001f, 0);
        //transform.parent.position = transform.position - SinirA.localPosition;

       //SinirA.localPosition = transform.parent.position;



        Transform SinirA = gameObject.transform;
        SinirA.position = transform.parent.position;
    }

}


using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript8 : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;

   //public float gethiz()
   // {
   //     return hiz;

   // }

    //public void setHiz(float hiz)
    //{
      //  this.hiz = hiz;
    //}


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * hiz;
        fizik.velocity = -transform.forward * hiz;
        



    }
}

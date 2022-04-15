using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript10 : MonoBehaviour
{
    Rigidbody fizik;
    public float hiz;


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere * hiz;
        fizik.velocity = -transform.right * hiz;



    }
}

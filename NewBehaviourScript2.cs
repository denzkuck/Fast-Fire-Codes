using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.UI;


public class NewBehaviourScript2 : MonoBehaviour
{


    public Transform[] target;
    public float speed;
    private int current;
    public Vector3 pos;
   

    public static System.Random random = new System.Random();

   

    void Update()
    {

        //current = random.Next(1, 5);



        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
        else
        {
            //current = (current + 1) % target.Length;
            current = random.Next(1, 200) % target.Length;
        }



    }




}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript27 : MonoBehaviour
{
    public GameObject patlama3;




    async void Update()
    {




        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {


                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == "fireslow")
                    {

                        Destroy(hit.transform.gameObject);
                        Instantiate(patlama3, hit.transform.position, hit.transform.rotation);






                    }

                }

            }
        }




    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class NewBehaviourScript5 : MonoBehaviour
{
    public GameObject patlama2;
    



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
                    if (hit.collider.tag == "fire")
                    {

                        Destroy(hit.transform.gameObject);
                        Instantiate(patlama2, hit.transform.position, hit.transform.rotation);






                    }

                }

            }
        }
        


             
    }
}


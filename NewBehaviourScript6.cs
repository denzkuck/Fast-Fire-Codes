using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript6 : MonoBehaviour
{
    
    public GameObject patlama2;
    public GameObject patlama;

    void DestroyAll(string tag)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tag);


        for (int i = 0; i < enemies.Length; i++)
        {
            GameObject.Destroy(enemies[i]);
            Instantiate(patlama, enemies[i].transform.position, enemies[i].transform.rotation);



        }
    }



    void Update()
    {
        


        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {


                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.tag == "firedest")
                    {
                        DestroyAll("water");
                        Destroy(hit.transform.gameObject);
                        Instantiate(patlama2, hit.transform.position, hit.transform.rotation);
                        


                    }

                }

            }
        }
    }
}

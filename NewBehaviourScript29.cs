using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript29 : MonoBehaviour
{
    public int health;
    public static NewBehaviourScript29 instance;
    public GameObject patlama;
    public GameObject patlamasu;
    public NewBehaviourScript31 newBehaviourScript31;
    
    
    
    
  

    public void Start()
    {
       
        health = 100;
        instance = this;


    }

   

    

    void bastan()
    {
        SceneManager.LoadScene("Fast Fire Game Over");
    }
     async void OnTriggerEnter(Collider col)
    {
       


        if (col.tag == "water")
        {
            Instantiate(patlamasu, col.transform.position, col.transform.rotation);
            Destroy(col.gameObject);

           
               
            
            
            

            health -= 10;

            


            Debug.Log(health);
            newBehaviourScript31.onTakeDamage(10);
            if (health <= 0)
            {
                Destroy(gameObject);
               
              
                Instantiate(patlama, transform.position, transform.rotation);
                await Task.Delay(1000);
               
                bastan();
                

                health = 0;
            }
            
            

        }
    }
}

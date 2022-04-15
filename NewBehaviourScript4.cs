using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class NewBehaviourScript4 : MonoBehaviour
{
    
    public GameObject patlama;
    //public GameObject playerPatlama;
    
    /*public float timer = 0.0f;
    bool a;
    public float htimer = 0;
    [SerializeField] Text Timerrr;

    //[SerializeField] Text Timerrr;


    void Start()
    {
        a = true;
        htimer = PlayerPrefs.GetFloat("enyüksek");
        //  Debug.Log("en yüksek zaman : " + seconds);
        Debug.Log("en yuksek zaman : " + htimer);
    }*/

    



    /*void bastan()
    {
        
       SceneManager.LoadScene("Fast Fire Game Over");
        
        
    }
    
    
        */
    




    async void OnTriggerEnter(Collider col)
    {

        
        

        if (col.tag == "dis")
        {

            Destroy(gameObject);


        }



         /*if (col.tag == "Player")
         {
            


            //a = false;
            //PlayerPrefs.SetFloat("zaman1", timer);






            //Destroy(col.gameObject);

            
            
            
           
            
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
                
                


        }*/
       
        
        /*if (col.tag == "Player")
        {
           
            Instantiate(playerPatlama, col.transform.position, col.transform.rotation);
            //await Task.Delay(1000);

           // bastan();
            
            
            

        }
        */
        
       

    }

    void Update()
    {


        /*if (a == true)
        {
            timer += Time.deltaTime;
            Timerrr.text = timer.ToString("000");
        }*/
      //  Debug.Log(timer);
        //  float seconds = timer % 60;






        for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {

                    
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                RaycastHit hit;
                    if (Physics.Raycast(ray,out hit))
                {
                    if (hit.collider.tag == "water")
                    {
                        
                        
                        Destroy(hit.transform.gameObject);
                        Instantiate(patlama, hit.transform.position, hit.transform.rotation);
                        
                       
                    }
                    
                }
                       
                }
            }
        





    }
    














}

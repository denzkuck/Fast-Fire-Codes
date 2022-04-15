using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    
    public GameObject playerPatlama1;
    //public float timer = 0.0f;
    //bool a;
    //public float htimer = 0;
    //[SerializeField] Text Timerrr;
    

  


    /*void Start()
    {
        a = true;
     htimer=   PlayerPrefs.GetFloat("enyüksek");
     //  Debug.Log("en yüksek zaman : " + seconds);
        Debug.Log("en yuksek zaman : "+htimer);
    }
    void Update()
    {

        if (a == true)
        {
            timer += Time.deltaTime;
            Timerrr.text = timer.ToString("000");
        }
        Debug.Log(timer);
        //  float seconds = timer % 60;
    }*/



    public void bastan()
    {
       
        SceneManager.LoadScene("Fast Fire Game Over");
    }



    private async void OnTriggerEnter(Collider col)
    {




        if (col.tag == "Player")
        {
            
            
            //a = false;
            //PlayerPrefs.SetFloat("zaman", timer);
            Destroy(col.gameObject);

            


        }
        if (col.tag == "Player")
        {

            Instantiate(playerPatlama1, col.transform.position, col.transform.rotation);
            await Task.Delay(1000);
            bastan();
        }

        /*if (timer > htimer)
        {
            htimer = timer;
            PlayerPrefs.SetFloat("enyüksek", htimer);
        }*/
    }

}

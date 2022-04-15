using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript24 : MonoBehaviour
{
    public float timer = 0.0f;
    //bool b;
    public float htimer = 0;
    [SerializeField] Text Timerrr;
    void Start()
    {
                //b = true;
        htimer = PlayerPrefs.GetFloat("enyüksek");
        //  Debug.Log("en yüksek zaman : " + seconds);
        //Debug.Log("en yuksek zaman : " + htimer);
    }

    void Update()
    {

        /*if (b == true)*/
        //{
        PlayerPrefs.SetFloat("zaman", timer);
        timer += Time.deltaTime;
            Timerrr.text = "RUN TIME : "+timer.ToString("000");
        //}
        //Debug.Log(timer);
        //  float seconds = timer % 60;
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "water" || col.tag=="sinirsu")
        {


            //b = false;
            PlayerPrefs.SetFloat("zaman", timer);
            if (timer > htimer)
            {
                htimer = timer;
                PlayerPrefs.SetFloat("enyüksek", htimer);
            }

        }




        /*if (timer > htimer)
        {
            htimer = timer;
            PlayerPrefs.SetFloat("enyüksek", htimer);
        }*/

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

public class NewBehaviourScript1 : MonoBehaviour
{

    public GameObject suPatlama1;

    /*async public void Start()
    {
         await Task.Delay(7000);
         gameObject.SetActive(false);




 }*/

    public void Start()
    {
        StartCoroutine(timegreen());
    }


    IEnumerator timegreen()
    {
        
        yield return new WaitForSeconds(4);
        gameObject.SetActive(false);
    }
    




    private void OnTriggerEnter(Collider col)
    {




        if (col.tag == "water")
        {



            Destroy(col.gameObject);



        }
        if (col.tag == "water")
        {

            Instantiate(suPatlama1, col.transform.position, col.transform.rotation);

        }


    }
    
}

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class NewBehaviourScript16 : MonoBehaviour
{
    
    void Start()
    {
        Transform dongu1 = transform.Find("Dongu1");
        dongu1.gameObject.SetActive(false);
        Transform dongu2 = transform.Find("Dongu2");
        dongu2.gameObject.SetActive(false);
        Transform dongu3 = transform.Find("Dongu3");
        dongu3.gameObject.SetActive(false);
        StartCoroutine(oyun());
    }

    
     IEnumerator oyun()
    {
        yield return new WaitForSeconds(15);
        Transform dongu = transform.Find("Dongu");
        dongu.gameObject.SetActive(false);


        Transform dongu1 = transform.Find("Dongu1");
        dongu1.gameObject.SetActive(true);
        yield return new WaitForSeconds(45);
        dongu1.gameObject.SetActive(false);

        Transform dongu2 = transform.Find("Dongu2");
        dongu2.gameObject.SetActive(true);
        yield return new WaitForSeconds(60);
        dongu2.gameObject.SetActive(false);

        Transform dongu3 = transform.Find("Dongu3");
        dongu3.gameObject.SetActive(true);
        yield return new WaitForSeconds(480);
        dongu3.gameObject.SetActive(false);
        SceneManager.LoadScene("Fast Fire Well");

    }
}

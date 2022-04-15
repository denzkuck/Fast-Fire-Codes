using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class NewBehaviourScript15 : MonoBehaviour
{
    public GameObject Sari;
    public GameObject Yesil;
    public GameObject Mavi;
    public GameObject Mor;
    public GameObject Beyaz;
    public Vector3 randomposy;
    public Vector3 randomposm;
    public Vector3 randomposp;
    public Vector3 randomposs;
    public Vector3 randomposw;
    public float basbekleme;
    //public float olusbekleme;
    public float dongubekleme;
    public static System.Random random = new System.Random();


    async void Start()
    {
        StartCoroutine(olustur());
    }
    void DestroyYM(string tag)
    {
        GameObject yates = GameObject.FindGameObjectWithTag(tag);
        GameObject.Destroy(yates);
    }

     IEnumerator olustur()
    {
        yield return new WaitForSeconds(basbekleme);
        while (true)
        {

            for (int j = 0; j < 1; j++)
            {
                int sayi = random.Next(1, 51);


                if (sayi % 7 == 0)
                {


                    for (int i = 0; i < 1; i++) 
                    {


                    for (int u = 0; u < 1; u++)
                    {

                        Vector3 mec = new Vector3(Random.Range(-randomposy.x, randomposy.x), 0.3f, Random.Range(-randomposy.z, randomposy.z));
                        Instantiate(Yesil, mec, Quaternion.Euler(90, 0, 0));
                        //yield return new WaitForSeconds(olusbekleme);
                        yield return new WaitForSeconds(2);
                        DestroyYM("fire");




                    }
                        yield return new WaitForSeconds(5);

                }




                }

                if (sayi%2 == 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        
                        Vector3 vec = new Vector3(Random.Range(-randomposm.x, randomposm.x), 0.3f, Random.Range(-randomposm.z, randomposm.z));
                        Instantiate(Mavi, vec, Quaternion.Euler(90,0,0));
                        //yield return new WaitForSeconds(olusbekleme);
                        yield return new WaitForSeconds(2);
                        DestroyYM("firedest");


                    }
                }


                if (sayi % 3 == 0)
                {
                    for (int d = 0; d < 1; d++)
                    {

                        Vector3 nec = new Vector3(Random.Range(-randomposm.x, randomposm.x), 0.3f, Random.Range(-randomposm.z, randomposm.z));
                        Instantiate(Mor, nec, Quaternion.Euler(90, 0, 0));
                        //yield return new WaitForSeconds(olusbekleme);

                        Vector3 vec = new Vector3(Random.Range(-randomposm.x, randomposm.x), 0.3f, Random.Range(-randomposm.z, randomposm.z));
                        Instantiate(Mavi, vec, Quaternion.Euler(90, 0, 0));

                        yield return new WaitForSeconds(2);
                        DestroyYM("fireslow");
                        DestroyYM("firedest");





                    }
                }
                if (sayi % 3 == 0)
                {
                    for (int m = 0; m < 1; m++)
                    {

                        Vector3 nec = new Vector3(Random.Range(-randomposs.x, randomposs.x), 0.3f, Random.Range(-randomposs.z, randomposs.z));
                        Instantiate(Sari, nec, Quaternion.Euler(90, 0, 0));
                        //yield return new WaitForSeconds(olusbekleme);


                        yield return new WaitForSeconds(2);
                        DestroyYM("fireh");
                        





                    }
                }
                if (sayi % 5 == 0)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        for (int w = 0; w < 1; w++)
                    {

                        Vector3 nec = new Vector3(Random.Range(-randomposw.x, randomposw.x), 0.3f, Random.Range(-randomposw.z, randomposw.z));
                        Instantiate(Beyaz, nec, Quaternion.Euler(90, 0, 0));
                        //yield return new WaitForSeconds(olusbekleme);


                        yield return new WaitForSeconds(2);
                        DestroyYM("firew");






                    }
                    }
                    yield return new WaitForSeconds(6);
                }




            }
            yield return new WaitForSeconds(dongubekleme);
        }
    }
}

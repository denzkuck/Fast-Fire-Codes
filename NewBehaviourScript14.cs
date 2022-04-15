using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.UI;

public class NewBehaviourScript14 : MonoBehaviour
{
    public Vector3 randomposm;
    public GameObject Mavi;
    public static System.Random random = new System.Random();


    public GameObject patlama;
    public GameObject patlama1;
    public GameObject patlama2;
    public GameObject patlama3;
    public GameObject patlama4;
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    int puan = 0;
    public Text puantext;
    int enyuksekpuan = 0;
    public float speed = 25f;
    bool slow = false;
    public NewBehaviourScript31 newBehaviourScript31;
    public GameObject patlama5;
    private NewBehaviourScript29 newBehaviourScript29;

    //public GameObject sınır;
    //public GameObject sınır1;
    //public GameObject sınır2;
    //public GameObject sınır3;



    // async void ac(string tag)
    //{

    //  Instantiate(Resources.Load(tag) as GameObject);
    //sınır1 = GameObject.FindGameObjectWithTag(tag);
    //sınır2 = GameObject.FindGameObjectWithTag(tag);
    //sınır3 = GameObject.FindGameObjectWithTag(tag);

    //GameObject[] sınırs = { sınır, sınır1, sınır2, sınır3 };
    //for(int i = 0; i < 1; i++)
    //{
    //    GameObject.Instantiate(sınırs[i]);
    //}

    //GameObject yesilsinir = GameObject.FindGameObjectWithTag(tag);
    //yesilsinir.SetActive(true);
    //await Task.Delay(10000);
    //yesilsinir.SetActive(false);


    void Start()
    {
        if (puan == 0)
        {

            PlayerPrefs.SetInt("puan", 0);
        }
        enyuksekpuan = PlayerPrefs.GetInt("yuksek");

        Debug.Log(enyuksekpuan);
       

        
    }


    void DestroyYM(string tag)
    {
        GameObject yates = GameObject.FindGameObjectWithTag(tag);
        GameObject.Destroy(yates);
    }





     public  IEnumerator olustur()
    {
        
        yield return new WaitForSeconds(0.1f);
        slow = !slow;
        Time.timeScale = slow ? .1f : 1f;
        speed = slow ? speed * 1 / Time.timeScale : 25f;

    }

    IEnumerator mol()
    {
        for (int i = 0; i < 6; i++)
        {

            Vector3 vec = new Vector3(Random.Range(-randomposm.x, randomposm.x), 0.3f, Random.Range(-randomposm.z, randomposm.z));
            Instantiate(Mavi, vec, Quaternion.Euler(90, 0, 0));
            //yield return new WaitForSeconds(olusbekleme);
            //StartCoroutine(mbekle());
            yield return new WaitForSeconds(1);
            DestroyYM("firedest");
            //StartCoroutine(nbekle());



        }


    }
    





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



        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            Plane objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);
            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(mRay, out rayDistance))
            {
                this.transform.position = mRay.GetPoint(rayDistance);
            }

            RaycastHit hit;
            if (Physics.Raycast(mRay, out hit))
            {
                if (hit.collider.tag == "water")
                {


                    Destroy(hit.transform.gameObject);
                    Instantiate(patlama, hit.transform.position, hit.transform.rotation);


                }

                if (hit.collider.tag == "firedest")
                {
                    
                    puan = puan + 1;
                    puantext.text = "SCORE : " + puan;
                    PlayerPrefs.SetInt("puan", puan);
                   
                    
                    DestroyAll("water");
                    Destroy(hit.transform.gameObject);
                    Instantiate(patlama1, hit.transform.position, hit.transform.rotation);


                }
                if (hit.collider.tag == "fire")
                {
                   
                    puan = puan + 3;
                    puantext.text = "SCORE : " + puan;
                    PlayerPrefs.SetInt("puan", puan);
                   
                    a1.active = true;
                    GameObject go = GameObject.Find("a1");
                    NewBehaviourScript1 other = (NewBehaviourScript1)go.GetComponent(typeof(NewBehaviourScript1));
                    other.Start();
                    a2.active = true;
                    GameObject go1 = GameObject.Find("a2");
                    NewBehaviourScript1 other1 = (NewBehaviourScript1)go1.GetComponent(typeof(NewBehaviourScript1));
                    other1.Start();
                    a3.active = true;
                    GameObject go2 = GameObject.Find("a3");
                    NewBehaviourScript1 other2 = (NewBehaviourScript1)go2.GetComponent(typeof(NewBehaviourScript1));
                    other2.Start();
                    a4.active = true;
                    GameObject go3 = GameObject.Find("a4");
                    NewBehaviourScript1 other3 = (NewBehaviourScript1)go3.GetComponent(typeof(NewBehaviourScript1));
                    other3.Start();



                    //gameObject.active = true;
                    Destroy(hit.transform.gameObject);
                    Instantiate(patlama2, hit.transform.position, hit.transform.rotation);
                    //await Task.Delay(10000);
                    //gameObject.active = false;
                    


                }
                if(hit.collider.tag == "fireslow")
                {


                    
                        slow = !slow;
                        Time.timeScale = slow ? .1f : 1f;
                        speed = slow ? speed * 1 / Time.timeScale : 25f;
                        Destroy(hit.transform.gameObject);
                        Instantiate(patlama3, hit.transform.position, hit.transform.rotation);
                        StartCoroutine( olustur());

                    
                      
                        





                }
                if (hit.collider.tag == "firew")
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(patlama4, hit.transform.position, hit.transform.rotation);
                    StartCoroutine(mol());



                }

                if (hit.collider.tag == "fireh")
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(patlama5, hit.transform.position, hit.transform.rotation);
                    newBehaviourScript31.fullfillhealth();
                    NewBehaviourScript29.instance.health = 100;
                }







                if (puan > enyuksekpuan)
                {
                    enyuksekpuan = puan;
                    PlayerPrefs.SetInt("yuksek", enyuksekpuan);
                }
            }



        }




        // await Task.Delay(10000);
        // gameObject.active = false;


    }
}

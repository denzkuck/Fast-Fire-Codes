﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript12 : MonoBehaviour
{
    public GameObject Su;
    public GameObject Su1;
    public GameObject Su2;
    public GameObject Su3;
    public Vector3 randompos;
    public Vector3 randompos1;
    public Vector3 randompos2;
    public Vector3 randompos3;
    public float basbekleme;
    public float olusbekleme;
    public float dongubekleme;
    public static System.Random random = new System.Random();



    void Start()
    {
        StartCoroutine(olustur());
    }

    IEnumerator olustur()
    {


        yield return new WaitForSeconds(basbekleme);
        //while (true)
        //{
            for (int j = 0; j < 95; j++)
            {

                int sayi = random.Next(1, 5);


                if (sayi == 4)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0.3f, -randompos.z);
                        Instantiate(Su, vec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 nec = new Vector3(Random.Range(-randompos1.x, randompos1.x), 0.3f, -randompos1.z);
                        Instantiate(Su1, nec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 mec = new Vector3(-randompos2.x, 0.3f, Random.Range(-randompos2.z, randompos2.z));
                        Instantiate(Su2, mec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);


                    }

                }
                if (sayi == 3)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0.3f, -randompos.z);
                        Instantiate(Su, vec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 nec = new Vector3(-randompos2.x, 0.3f, Random.Range(-randompos2.z, randompos2.z));
                        Instantiate(Su2, nec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 mec = new Vector3(-randompos3.x, 0.3f, Random.Range(-randompos3.z, randompos3.z));
                        Instantiate(Su3, mec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);

                    }
                }
                if (sayi == 2)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        Vector3 vec = new Vector3(Random.Range(-randompos.x, randompos.x), 0.3f, -randompos.z);
                        Instantiate(Su, vec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 nec = new Vector3(-randompos3.x, 0.3f, Random.Range(-randompos3.z, randompos3.z));
                        Instantiate(Su3, nec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 mec = new Vector3(Random.Range(-randompos1.x, randompos1.x), 0.3f, -randompos1.z);
                        Instantiate(Su1, mec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);


                    }
                }

                if (sayi == 1)
                {
                    for (int i = 0; i < 5; i++)
                    {

                        Vector3 vec = new Vector3(Random.Range(-randompos1.x, randompos1.x), 0.3f, -randompos1.z);
                        Instantiate(Su1, vec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 nec = new Vector3(-randompos2.x, 0.3f, Random.Range(-randompos2.z, randompos2.z));
                        Instantiate(Su2, nec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);
                        Vector3 mec = new Vector3(-randompos3.x, 0.3f, Random.Range(-randompos3.z, randompos3.z));
                        Instantiate(Su3, mec, Quaternion.identity);
                        yield return new WaitForSeconds(olusbekleme);


                    }
                }
                

                
            }
            yield return new WaitForSeconds(dongubekleme);
        //}
    }
}

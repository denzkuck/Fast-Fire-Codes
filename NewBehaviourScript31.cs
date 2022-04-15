using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript31 : MonoBehaviour
{

    public Image healthbar;
    public float health;
    public float starthealth;
    // Start is called before the first frame update
    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healthbar.fillAmount = health / starthealth;
        
    }

    public void fullfillhealth()
    {
        health = starthealth;
        healthbar.fillAmount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

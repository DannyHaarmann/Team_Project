using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animation;
    

    public void Start()
    {
        animation = GetComponent<Animator>();
        
}
    public int Health
    {
        set
        {
            if(value < 0)
            {
                animation.SetTrigger("Hit");
            }
            health = value;
            if(health <= 0)
            {
                animation.SetTrigger("dead");
                defeated();
            }
        }
        get
        {
            return health;
        }
    }

    public int health = 1;

 
   
    public void defeated()
    {
        animation.SetTrigger("dead");
        //Destroy(gameObject);
        print("Killed");
    }
    void OnHit(float damage)
    {
        Debug.Log("Slime hit for " + damage);
    }
    
}

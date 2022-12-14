using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    

    public void Start()
    {
        animator = GetComponent<Animator>();
        
}
    public int Health
    {
        set
        {
            if(value < 0)
            {
                
            }
            health = value;
            if(health <= 0)
            {
                animator.SetTrigger("dead");
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
        animator.SetTrigger("dead");
        //Destroy(gameObject);
        print("Killed");
    }
    void OnHit(float damage)
    {
        Debug.Log("Slime hit for " + damage);
    }
    
}

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
            
            health = value;
            if(health <= 0)
            {
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
        Destroy(gameObject);
        print("Killed");
        animator.SetTrigger("Defeated");
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript1 : MonoBehaviour
{
    Rigidbody2D rb;
    Effector2D eff;

    int health;

    void Awake()
    {
        this.health = 100;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        eff = this.gameObject.GetComponent<Effector2D>();
        
    }

    void Start()
    {
        Debug.Log("Enemy health: " + this.health);
    }

    int getHealth()
    {
        return this.health;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            this.health = health - 10;
            Debug.Log(this.health);
        }
    }

    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour,IDamageable
{
    public DetectionZone detectionZone;
    public float damage = 1f;
    public float knockbackForce = 100f;
    public float moveSpeed = 50f;
    private Rigidbody2D rb;
    Animator animator;
    public float _health = 3;
    bool isAlive = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        
        if(detectionZone.detectedObjs.Count > 0)
        {
            Vector2 direction = (detectionZone.detectedObjs[0].transform.position - transform.position).normalized;
            
            animator.SetBool("SlimeIsMoving" , true);
            rb.AddForce(direction * moveSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("SlimeIsMoving", false);
        }
    }
    public float Health
    {
        set
        {
            if(value < _health)
            {
                animator.SetTrigger("Hit");
            }

            _health = value;
            
            if (_health <= 0)
            { 
                animator.SetTrigger("dead");
                
                
            }
        }
        get
        {
            return _health;
        }
    }

 

    void OnCollisionEnter2d(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        //IDamageable damageable -collider.GetComponent<IDamageable>();

        Debug.Log("Slime hit " + damage);
    }
    void defeated()
    {
        Destroy(gameObject);
    }


    public void OnHit(float damage, Vector2 knockback)
    {
        Health -= damage;
        rb.AddForce(knockback);
    }


    public void deadboi()
    {
        Destroy(gameObject);
    }
}

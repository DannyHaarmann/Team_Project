using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeScript : MonoBehaviour
{
    public Collider2D bodyCollider;
    public int damage = 20;
    Vector2 attackOffset;

    public void Start()
    {
        attackOffset = transform.position;
    }

    public void attackRight()
    {
        bodyCollider.enabled = true;
        transform.position = attackOffset;
    }

    public void attackLeft()
    {
        bodyCollider.enabled = true;
        transform.position = new Vector2(attackOffset.x*-1, attackOffset.y);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            enemyScript1 enemy = other.GetComponent<enemyScript1>();

            if(enemy != null)
            {
                enemy.Health -= damage;
            }
        }
    }
}


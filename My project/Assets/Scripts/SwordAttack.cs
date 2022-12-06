using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

  
    Vector2 attackOffset;
    public Collider2D swordCollider;
    int health;
    public int damage = 3;
    // Start is called before the first frame update
    void Start()
    {
         
        attackOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void attackLeft()
    {
        print("attack left");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(attackOffset.x * -1, attackOffset.y);
        

    }
    public void attackRight()
    {
            print("attack right");
            swordCollider.enabled = true;
            transform.localPosition = attackOffset;

    }
    public void stopAttack()
    {
        swordCollider.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            print("Hit");
            Enemy enemy = collision.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.Health -= damage;
            }

        }
    }

}

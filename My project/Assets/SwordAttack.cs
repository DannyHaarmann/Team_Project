using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

  
    Vector2 attackOffset;
    Collider2D swordCollider;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        swordCollider = GetComponent<Collider2D>();
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
        transform.position = new Vector3(attackOffset.x * -1, attackOffset.y);
        health = health - 10;

    }
    public void attackRight()
    {
        print("attack rigth");
        swordCollider.enabled = true;
        transform.position = attackOffset;
        health = health - 10;
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
        }
    }

}

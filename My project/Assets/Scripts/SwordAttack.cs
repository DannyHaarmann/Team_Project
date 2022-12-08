using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

  
    Vector3 RightattackOffset;
    public Collider2D swordCollider;
    int health;
    public int damage = 3;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
         
        RightattackOffset = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }


    public void attackLeft()
    {
        print("attack left");
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(RightattackOffset.x * -1, RightattackOffset.y);
        
        

    }
    public void attackRight()
    {
            print("attack right");
            swordCollider.enabled = true;
            transform.localPosition = RightattackOffset;

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
            animator.SetTrigger("Hit");
            Enemy enemy = collision.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.Health -= damage;
            }

        }
    }

}

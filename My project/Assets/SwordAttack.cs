using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public enum attackDirection{ 
        left, right

    }
    public attackDirection MainattackDirection;
    Vector2 attackOffset;
    Collider2D swordCollider;
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
    public void Attack()
    {
        switch(MainattackDirection)
        {
            case attackDirection.left: attackLeft();
                break;
            case attackDirection.right: attackRight();
                break;
        }
    }
    public void attackLeft()
    {
        print("attack left");
        swordCollider.enabled = true;
        transform.position = new Vector3(attackOffset.x * -1, attackOffset.y);
    }
    public void attackRight()
    {
        print("attack rigth");
        swordCollider.enabled = true;
        transform.position = attackOffset;
    }
    public void stopAttack()
    {
        swordCollider.enabled = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public Collider2D swordCollider;
    public float swordDamage = 1f;
    public float knockbackForce = 1000f;
    public Vector3 faceRight = new Vector3(.15f, .01f, 0);
    public Vector3 faceLeft = new Vector3(-.15f, .01f, 0);
    public int damage = 3;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if(swordCollider == null)
        {
            Debug.Log("Sword no worky");
            animator = GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Health -= damage;
                animator.SetTrigger("Hit");
            }
            IDamageable damageableObject = collision.GetComponent<IDamageable>();
            if (damageableObject != null)
            {
                Debug.Log("Hit slime");
                Vector3 parentPosition = transform.parent.position;
                Vector2 direction = (Vector2)(collision.gameObject.transform.position - parentPosition).normalized;
                Vector2 knockback = direction * knockbackForce;

                damageableObject.OnHit(swordDamage, knockback);
            }
        }

    }
    void IsFacingRight(bool isFacingRight)
    {
        if(isFacingRight)
        {
            gameObject.transform.localPosition = faceRight;
        }
        else
        {
            gameObject.transform.localPosition = faceLeft;
        }
    }
  

}

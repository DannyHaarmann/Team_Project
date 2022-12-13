using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public Collider2D swordCollider;
    public float swordDamage = 1f;
    // Start is called before the first frame update
    void Start()
    {
        if(swordCollider == null)
        {
            Debug.Log("Sword no worky");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.SendMessage("OnHit", swordDamage);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public DetectionZone detectionZone;
    public float damage = 1f;
    public float knockbackForce = 100f;
    public float moveSpeed = 4f;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        
        if(detectionZone.detectedObjs.Count > 0)
        {
            Vector2 direction = (detectionZone.detectedObjs[0].transform.position - transform.position).normalized;
            rb.AddForce(direction * moveSpeed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2d(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        //IDamageable damageable -collider.GetComponent<IDamageable>();

        Debug.Log("Slime hit " + damage);
    }
}

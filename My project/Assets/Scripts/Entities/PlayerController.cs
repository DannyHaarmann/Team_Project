using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rb;
    public float MoveSpeed = 1F;
    public float collisionOffset = 0.05F;
    public ContactFilter2D movementfilter;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    Animator animator;
    SpriteRenderer SpriteRenderer;

    public MeleeScript bodyAttack;

    int health = 100;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("Player health: " + health);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (movementInput != Vector2.zero)
        {
            bool success = TryMove(movementInput);
            if (!success)
            {
                success = TryMove(new Vector2(movementInput.x, 0));
                if (!success)
                {
                    success = TryMove(new Vector2(0, movementInput.y));
                }
            }
            animator.SetBool("IsMoving", success);
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }
        if (movementInput.x < 0)
        {
            SpriteRenderer.flipX = true;
        }
        else if (movementInput.x > 0)
        {
            SpriteRenderer.flipX = false;
        }

    
    }
    
    private bool TryMove(Vector2 direction)
    {
        int count = rb.Cast(movementInput, movementfilter, castCollisions, MoveSpeed * Time.fixedDeltaTime + collisionOffset);
        if (count == 0)
        {
            rb.MovePosition(rb.position + movementInput * MoveSpeed * Time.fixedDeltaTime);
            return true;
        }
        else
        {
            return false;
        }
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
   
    void OnFire()
    {
        animator.SetTrigger("SwingSword");
    }

    

}

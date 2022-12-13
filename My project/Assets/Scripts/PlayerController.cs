using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public SaveLoadSystem.SaveData SaveFile = SaveLoadSystem.SaveGameManager.CurrentSaveData;
    Vector2 movementInput;
    Rigidbody2D rb;
    public float MoveSpeed = 1F;
    public float collisionOffset = 0.05F;
    public ContactFilter2D movementfilter;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    //public static List<Item> Inventory = new List<Item>();
    //public static List<Item> Inventory = new List<Item>();
    Animator animator;
    SpriteRenderer SpriteRenderer;
    public SwordAttack swordAttack;


    public bool canMove = true;
    public int health = 50;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //if loadad:
            rb.position = SaveFile.getPositionCoords();
            this.health = SaveFile.getCurrentHealth();
        animator = GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        SaveFile.setPositionCoords(rb.position);
        SaveFile.setCurrentHealth(this.health);
        if (canMove)
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

    public void SwordAttack()
    {
        lockMovment();
        
        if (SpriteRenderer.flipX == true)
        {
            swordAttack.attackLeft();
        }
        else
        {
            swordAttack.attackRight();
        }
        
    }
    public void endAttack()
    {
        unlockMovement();
        print("End Swing");

        swordAttack.stopAttack();

    }
    public void lockMovment()

    {
        canMove = false;
    }
    public void unlockMovement()
    {
        canMove = true;
    }

    public int getHealth()
    {
        return health;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            print("Exit collision");
            health = health - 1;
        }
    }

    /* public static void addToInventory(Item item)
    {
        Inventory.Add(item);
    } */

}

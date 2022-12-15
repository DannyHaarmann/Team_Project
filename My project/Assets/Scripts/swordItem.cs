using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordItem : MonoBehaviour   
{
    public GameObject Interaction;
    public GameObject Sword;
    private bool onSword;
    private int damage;
    public GameObject swordInventoryImage;
    public GameObject itself;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onSword = Interaction.GetComponent<InteractScript>().checkSword();
        
        if(onSword == true)
        {
            if(Input.GetKeyDown("e"))
            {
                Destroy(this.gameObject);
                Sword.GetComponent<SwordAttack>().setDamage(10);
                swordInventoryImage.SetActive(true);
                itself.SetActive(false);
            }
        } 
        
    }
}

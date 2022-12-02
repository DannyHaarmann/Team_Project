using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    //public Collider2D interactionCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        while(collision.tag == "Chest")
        {
            if(Input.GetKeyDown("e"))
            {
                print("Open Chest");
            }

        }
    }
}

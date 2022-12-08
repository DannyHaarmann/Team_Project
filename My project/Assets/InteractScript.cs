using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{

    public static bool ChestIsOpen = false;
    private bool isChest;
    private bool onSword;
    public GameObject ChestUI;
    public GameObject HealthUI;
    public GameObject interactionColl;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(isChest)
            {
                if (Input.GetKeyDown("e"))
                {
                    if (ChestIsOpen)
                    {
                        Resume();
                    }
                    else
                    {
                        Pause();
                    }
                }
                
            }
            else if(onSword)
            {
                if(Input.GetKeyDown("e"))
                {
                    //Destroy();
                }
            }
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Chest")
        {
            isChest = true;
        }
        else if(coll.tag == "Sword")
        {
            onSword = true;
            interactionColl = coll.GetComponent<GameObject>();
            Debug.Log(interactionColl);
        }
    }

    public void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Chest")
        {
            isChest = false;
        }
        else if(coll.tag == "Sword")
        {
            onSword = false;
            interactionColl = null;
        }
    }

    public void Resume()
    {
        this.ChestUI.SetActive(false);
        HealthUI.SetActive(true);
        Time.timeScale = 1f;
        ChestIsOpen = false;
        transform.localPosition = new Vector3();
    }

    public void Pause()
    {
        this.ChestUI.SetActive(true);
        HealthUI.SetActive(false);
        Time.timeScale = 0f;
        ChestIsOpen = true;
        transform.localPosition = new Vector3();
    }
}

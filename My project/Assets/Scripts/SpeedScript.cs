using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{
    public GameObject Interaction;
    public GameObject Player;

    private bool onPotion;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        onPotion = Interaction.GetComponent<InteractScript>().checkSpeedPot();

        if (onPotion == true)
        {
            if (Input.GetKeyDown("e"))
            {
                Destroy(this.gameObject);
                Player.GetComponent<PlayerController>().setSpeed(10f);
            }
        }


    }
}

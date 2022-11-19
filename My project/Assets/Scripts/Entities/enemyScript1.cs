using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript1 : MonoBehaviour
{
   public int Health
    {
        set
        {
            print(value);
            health = value;
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }
        get
        {
            return health;
        }
    }

    public int health = 100;

   

    
}

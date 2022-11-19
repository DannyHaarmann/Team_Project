using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpScript : MonoBehaviour
{
    public GameObject otherTP;

    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.transform.position = new Vector2(this.otherTP.transform.position.x, this.otherTP.transform.position.y - 2);
    }

    void Update()
    {
        
    }
}

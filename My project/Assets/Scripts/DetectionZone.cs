using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{

    public List<Collider2D> detectedObjs = new List<Collider2D>();
    public Collider2D collision;
    string tagTarget = "Player";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("entered aggro");

            detectedObjs.Add(collision);
        }
        
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        detectedObjs.Remove(collision);
    }
}

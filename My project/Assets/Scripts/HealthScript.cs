using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public GameObject Player;
    public SaveLoadSystem.SaveData SaveFile = SaveLoadSystem.SaveGameManager.CurrentSaveData;
    public Text healthText;
    int health;

    // Start is called before the first frame update
    void Start()
    {
        health = Player.GetComponent<PlayerController>().getHealth();
        Text text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        health = Player.GetComponent<PlayerController>().getHealth();
        healthText.text = ("Health: " + health);
        if(health <= 0)
        {
            Destroy(Player);
            SceneManager.LoadScene("DeathScreen");
        }
    }
}


 
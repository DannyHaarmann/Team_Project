using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private string Enemy_name;
    private int health;
    private ArrayList items;

    public enemy(string Enemy_name, int health, ArrayList items)
    {
        this.Enemy_name = Enemy_name;
        this.health = health;
        this.items = items;
    }

    public string getName()
    {
        return this.Enemy_name;
    }

    public int getHealth()
    {
        return this.health;
    }

    public ArrayList getItems()
    {
        return this.items;
    }

    public void setHealth(int health)
    {
        this.health = health;
    }
    /*
    public void giveItem(Item item)
    {
        items.Add(item);
    }

    public void takeItem(Item item)
    {
        items.Remove(item);
    }
    */
}

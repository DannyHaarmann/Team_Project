using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private string name;
    private int health;
    private ArrayList items;

    public enemy(string name, int health, ArrayList items)
    {
        this.name = name;
        this.health = health;
        this.items = items;
    }

    public string getName()
    {
        return this.name;
    }

    public int getHealth()
    {
        return this.health;
    }

    public string[] getItems()
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

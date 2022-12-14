using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string name;
    private string type;
    private int ATK;
    private int value;
    private int health;
   // private bool isFood = false;
   // private bool isCoin = false;
   // private bool isWeapon = false;
    

    

    public Item(string name, string type)
    {
        this.name = name;
        this.type = type;

    }

    public void setWeapon(int ATK)
    {
        this.ATK = ATK;
    }

    public int getATK(Item i)
    {
        return this.ATK;
    }

    public void setFood(int health)
    {
        this.health = health;
    }

    public int getHealth(Item i)
    {
        return this.health;
    }

    public void setCoin(int value)
    {
        this.value = value;
    }

    public int getValue(Item i)
    {
        return this.value;
    }

    /* public void addToInventory(Item item)
    {
        PlayerController.addToInventory(this);
    } */
}
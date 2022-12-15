using System;
using UnityEngine;

namespace SaveLoadSystem
{
    [System.Serializable]
    public class SaveData
    {
        [SerializeField] private int MaxHealth;
        [SerializeField] private int CurrentHealth;
        [SerializeField] private Vector2 PositionCoords;
        //public bool LoadedFromSave = false;

        public int getCurrentHealth() {
            return this.CurrentHealth;
        }

        public int getMaxHealth() {
            return this.MaxHealth;
        }

        public Vector2 getPositionCoords() {
            return this.PositionCoords;
        }

        public void setCurrentHealth(int num) {
            this.CurrentHealth = num;
            if(num > this.MaxHealth) {
                this.CurrentHealth = this.MaxHealth;
            }
        }

        public void setMaxHealth(int num) {
            this.MaxHealth = num;
        }

        public void setPositionCoords(Vector2 coords) {
            this.PositionCoords = coords;
        }
    }
}
using System;
using UnityEngine;

namespace SaveLoadSystem
{
    [System.Serializable]
    public class SaveData
    {
        [SerializeField] private int CurrentHealth;
        [SerializeField] private Vector2 PositionCoords;
        //public bool LoadedFromSave = false;

        public int getCurrentHealth() {
            return this.CurrentHealth;
        }

        public Vector2 getPositionCoords() {
            return this.PositionCoords;
        }

        public void setCurrentHealth(int num) {
            this.CurrentHealth = num;
        }

        public void setPositionCoords(Vector2 coords) {
            this.PositionCoords = coords;
        }
    }
}
using System;
using UnityEngine;

<<<<<<< Updated upstream
namespace SaveLoadSystem {
    public class SaveData : MonoBehaviour
    {
        public SaveData() {

            public string greeting = "hello";
        }
=======
namespace SaveLoadSystem
{
    [System.Serializable]
    public class SaveData
    {
        [SerializeField] private int MaxHealth = 10;
        [SerializeField] private int CurrentHealth = 10;
        [SerializeField] private Vector2 PositionCoords = new Vector2(0,0);



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
>>>>>>> Stashed changes
    }
}
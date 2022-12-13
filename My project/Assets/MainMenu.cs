using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SaveLoadSystem{
    public class MainMenu : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void QuitGame()
        {
            Debug.Log("The game has been quit.");
            Application.Quit();
        }

        public void OpenCredits()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);

        }

<<<<<<< Updated upstream
    public void BackFromCredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
=======
        public void BackFromCredits()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }

        public void BackFromDeath()
        {
            SceneManager.LoadScene("Menu");
        }

<<<<<<< Updated upstream
        public void SaveGame() {
            SaveGameManager.CurrentSaveData = new SaveData();
=======
        public void SaveGame()
        {
>>>>>>> Stashed changes
            SaveGameManager.SaveGame();
        }

        public void LoadGame() {
            SaveGameManager.LoadGame();
        }

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
        public void LoadFromDeath()
        {
            this.LoadGame();
            SceneManager.LoadScene("SampleScene");
        }
>>>>>>> Stashed changes
    }
}

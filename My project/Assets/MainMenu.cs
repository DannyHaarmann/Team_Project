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

        public void SaveGame() {
            SaveGameManager.CurrentSaveData = new SaveData();
            SaveGameManager.SaveGame();
            Debug.Log("Game Saved");
        }

        public void LoadGame() {
            SaveGameManager.LoadGame();
            Debug.Log("Game Loaded");
        }

>>>>>>> Stashed changes
    }

    public void BackFromDeath()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadSave()
    {
        //load save
    }
}

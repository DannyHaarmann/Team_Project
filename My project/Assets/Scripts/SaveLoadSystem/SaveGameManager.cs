using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SaveLoadSystem 
{

    public static class SaveGameManager
    {
        public static SaveData CurrentSaveData = new SaveData();
        public const string SaveDirectory = "/SaveData/";
        public const string FileName = "Savegame.PlsDon'tCheat";
        public static bool loaded = false;

        public static bool SaveGame() 
        {
            var dir = Application.persistentDataPath + SaveDirectory;

            if(!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            string json = JsonUtility.ToJson(CurrentSaveData, true);
            File.WriteAllText(dir + FileName, json);

            GUIUtility.systemCopyBuffer = dir + FileName;

            return true;
        }

        public static bool LoadGame()
        {
            string fullPath = Application.persistentDataPath + SaveDirectory + FileName;
            SaveData tempData = new SaveData();

            if(!File.Exists(fullPath))
            {
                Debug.LogError("Save File does not exist");
                return false;
            } 
            string json = File.ReadAllText(fullPath);
            tempData = JsonUtility.FromJson<SaveData>(json);

            CurrentSaveData = tempData;
            Debug.Log("Save Loaded");
            loaded = true;
            return true;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public GameData playerData;
    public HighScoreData highscoreData;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    public class GameData
    {
        public string playerName;
    }
    [System.Serializable]
    public class HighScoreData
    {
        public string playerName;
        public int highScore;
    }
    public void LoadHighScore()
    {

        string path = Application.persistentDataPath + "/highScore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Instance.highscoreData = JsonUtility.FromJson<HighScoreData>(json);
        }
    }
    public void SaveHighScore()
    {
        string json = JsonUtility.ToJson(Instance.highscoreData);
        File.WriteAllText(Application.persistentDataPath + "/highScore.json", json);
    }
}

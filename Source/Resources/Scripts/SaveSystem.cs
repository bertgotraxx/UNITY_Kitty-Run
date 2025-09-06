using System;
using System.IO;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public const string SAVE_FILE_NAME = "/PLAYERDATA.json";
    public static void SaveGameData()
    {
        string saveFilePath = Application.persistentDataPath + SAVE_FILE_NAME;
        ScoreData scoreData = new ScoreData(GameObject.Find("ScoreTable"));
        SaveData saveData = new SaveData(scoreData);
        string txt = JsonUtility.ToJson(saveData);
        File.WriteAllText(saveFilePath, txt);
    }

    public static SaveData LoadGameData()
    {
        try {
            string saveFilePath = Application.persistentDataPath + SAVE_FILE_NAME;
            string fileContent = File.ReadAllText(saveFilePath);
            SaveData saveData = JsonUtility.FromJson<SaveData>(fileContent);
            return saveData;
        } 
        catch
        {
            return null;
        }
    }
}

[Serializable]
public class SaveData
{
    [SerializeField] public ScoreData scoreData;

    public SaveData(ScoreData scoreData)
    {
        this.scoreData = scoreData;
    }
}

[Serializable]
public class ScoreData
{
    [SerializeField] public int score;

    public ScoreData(GameObject scoreTable)
    {
        score = scoreTable.GetComponent<HighScore>().SCORE;
    }
}

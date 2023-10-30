using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class MainManager1 : MonoBehaviour
{
    public string input;
    public int bestScore;
    public static MainManager1 instance;

    public void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        Load();
    }


    [SerializeField] class SaveData
    {
        public string name;
        public int bestScore;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.name = input;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savejson", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savejson";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            input = data.name;
        }
    }
}

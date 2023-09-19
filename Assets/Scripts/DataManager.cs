using System;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    
    private const string _fileName = "PlayerData.txt";
    private string defaultFilePath;
    public PlayerData PlayerData { get; set; } = new PlayerData("admin", 1);
    public string filePath;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }



    private void Start()
    {
        defaultFilePath = Path.Combine(Application.dataPath, _fileName); ;
        filePath = defaultFilePath;
    }

    //returns true if exist and false if not
    public bool CheckData()
    {
        return File.Exists(filePath);
    }

    public void WriteData(/* some parameters */)
    {
        using (StreamWriter writer = new StreamWriter(filePath, append: false))
        {

            writer.WriteLine(PlayerData.name);
            writer.WriteLine(PlayerData.Health);
        }
    }

    public PlayerData ReadParameters()
    {
        if (!CheckData())
        {
            Debug.Log("File not found");
            return null;
        }

        string[] lines = File.ReadAllLines(filePath);

        return new PlayerData(lines[0], Convert.ToInt32(lines[1]));
    }
}

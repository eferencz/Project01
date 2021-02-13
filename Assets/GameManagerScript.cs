using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManagerScript : MonoBehaviour
{
    public string filepath = "log.txt";

    // Start is called before the first frame update
    void Start()
    {
        CreateFile();
        // ReadFile();
        WriteFile();
    }


    private void CreateFile()
    {
        if (!File.Exists(filepath))
        {
            File.Create(filepath).Close();
        }
    }

    private void ReadFile()
    {
        using (StreamReader reader = new StreamReader(filepath))
        {
            while(!reader.EndOfStream)
            {
                Debug.Log(reader.ReadLine());
            }
        }
    }

    private void WriteFile()
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            for (int i = 0; i < 10; i++)
            {
                writer.WriteLine(i.ToString());
            }
          
        }
    }
}

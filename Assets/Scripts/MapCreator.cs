using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapCreator : MonoBehaviour
{
    [SerializeField] private GameObject pillar;
    [SerializeField] TextAsset mapAsset;

    string path;

    private int posX = 0;
    private int posZ = 0;

    private string map;

    private string[] mapLines;
    // Start is called before the first frame update

    private void Awake()
    {
        path = Application.persistentDataPath + "/Map/map.txt";

        File.WriteAllText(path, mapAsset.ToString());
    }

    void Start()
    {
        ReadFileMap();
        CreateMap();
    }

    public void ReadFileMap()
    {
        map = File.ReadAllText(path);

        mapLines = map.Split('\n');
    }

    public void CreateMap()
    {
        for (int i = 0; i < mapLines.Length; i++)
        {
            for (int j = 0; j < mapLines[i].Length; j++)
            {
                switch (mapLines[i][j])
                {
                    case 'X':
                        Vector3 v = new Vector3(j * 2, 0 ,i * 2);
                        Instantiate(pillar, v, Quaternion.identity);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}


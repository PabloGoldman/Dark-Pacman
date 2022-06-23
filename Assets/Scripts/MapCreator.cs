using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MapCreator : MonoBehaviour
{
    [SerializeField] private GameObject pillar;

    private int posX = 0;
    private int posZ = 0;

    private string map;

    private string[] mapLines;
    // Start is called before the first frame update
    void Start()
    {
        ReadFileMap();
        CreateMap();
    }

    public void ReadFileMap()
    {
        FileStream fs = File.OpenRead("C:/map.txt"); //Hay que hacer lo del persistent data path

        StreamReader sr = new StreamReader(fs);

        map = sr.ReadToEnd();

        Debug.Log(map);

        mapLines = map.Split('\n');

        sr.Close();
        fs.Close();
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


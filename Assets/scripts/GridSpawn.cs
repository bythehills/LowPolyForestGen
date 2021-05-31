using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawn : MonoBehaviour
{
    public float offset = 1f;
    public Vector3 gridOrigin = Vector3.zero;
    public GameObject[] fallitems;
    public GameObject[] summeritems;
    public int x;
    public int z;

    public GameObject controller;
    public StartMenu controllerscript;

    public void Start()
    {
        if (PlayerPrefs.GetString("Theme", "Summer").Equals("Summer"))
        {
            GenerateGrid(summeritems);

        } else
        {
            GenerateGrid(fallitems);
        }
    }   

    void GenerateGrid(GameObject[] items)
    {
        for(int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
               //spawns a 1x1x1 cube at position (i, 0, j) 
                Vector3 spawn = new Vector3(i * offset, 0, j * offset);
                int rand = Random.Range(0, items.Length);
                Instantiate(items[rand], spawn, Quaternion.identity);
            }
        }
    }

    int[,] returnGrid()
    {
        int [,] arr = new int[x, z];
        return arr;
    }

}

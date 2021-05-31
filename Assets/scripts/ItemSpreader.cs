using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpreader : MonoBehaviour
{
    public GameObject gridSpawner;
    public GridSpawn gridscript;
    public GameObject[] fallitems; //generates trees
    public GameObject[] fallfoliage; //generates non tree objects
    public GameObject[] fallgrass; //bad idea but generates grass
    public GameObject[] summeritems; //generates trees
    public GameObject[] summerfoliage; //generates non tree objects
    public GameObject[] summergrass; //bad idea but generates grass
    public int num;
    public int grassnum;

    public GameObject controller;
    public StartMenu controllerscript;

    public void Start()
    {
        if (PlayerPrefs.GetString("Theme", "Summer").Equals("Summer"))
        {
            GenerateItems(summeritems, summerfoliage, summergrass);

        }
        else
        {
            GenerateItems(fallitems, fallfoliage, fallgrass);
        }

    }

    public void GenerateItems(GameObject[] items, GameObject[] foliage, GameObject[] grass)
    {
        gridscript = gridSpawner.GetComponent<GridSpawn>(); 
        for (int i = 0; i < num; i++)
        {
            int randx = Random.Range(0, gridscript.x); //choose a random x point within bounds of area
            int randz = Random.Range(0, gridscript.z);
            Vector3 spawn = new Vector3(randx, 0, randz); //spawnpoint for tree
            Vector3 folspawn = new Vector3(randx + Random.Range(-2, 2), 0, randz + Random.Range(-2, 2)); //generates foliage around trees
            int itemindex = Random.Range(0, items.Length);
            //instantiate random tree from tree array
            Instantiate(items[itemindex], spawn, Quaternion.identity); 

            int folindex = Random.Range(0, foliage.Length);
            Instantiate(items[itemindex], spawn, Quaternion.identity); //instantiate random tree from tree array
            Instantiate(foliage[folindex], folspawn, Quaternion.identity); //instantiate random foliage from foliage array

        }

        for (int i = 0; i < grassnum; i++)
        {
            int randx = Random.Range(0, gridscript.x); //choose a random x point within bounds of area
            int randz = Random.Range(0, gridscript.z);
            Vector3 spawn = new Vector3(randx, 0.45f, randz); //vector 3 spawnpoint for tree
            int grassindex = Random.Range(0, grass.Length);
            Instantiate(grass[grassindex], spawn, Quaternion.identity); //instantiate random tree from tree array

        }
    }
    
}

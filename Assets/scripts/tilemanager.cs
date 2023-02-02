using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour
{
    public GameObject[] tileprefabs;
    public float zspawn = 0f;
    public float tilelength = 30f;
    public int numboftiles = 6;
    public Transform playertransform;
    private List<GameObject> activetiles = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < numboftiles; i++)
        {
            if (i == 0)
            {
                spawntile(0);
            }
            else
            {
                spawntile(Random.Range(0, tileprefabs.Length));
            }
        }
        
    }


    void Update()
    {
        
        if (playertransform.position.z-100 > zspawn - (numboftiles * tilelength))
        {
            spawntile(Random.Range(0, tileprefabs.Length));
            DeleteTile();
        }
    }
    public void spawntile(int tileIndex)
    {
        GameObject go = Instantiate(tileprefabs[tileIndex], transform.forward * zspawn, transform.rotation);
        activetiles.Add(go);
        zspawn += tilelength;
    }
    private void DeleteTile()
    {
        Destroy(activetiles[0]);
        activetiles.RemoveAt(0);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn = 0f;
    [SerializeField]
    public float tileLength = 30;
    public int tileNumber = 5;
    public Transform targetTransform;
    private List<GameObject> activeTiles = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < tileNumber; i++)
        {
            if (i == 0)
            { SpawnTile(0); }

            else 
            {SpawnTile(Random.Range(0, tilePrefabs.Length)); }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (targetTransform.position.z > zSpawn - (tileNumber * tileLength)) 
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }
    public void SpawnTile(int tileIndex) 
    {
        GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }
    private void DeleteTile() 
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}

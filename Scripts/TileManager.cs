using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public  GameObject[] tilePrefabs;
    public float zSpawn;
    public float tileLenght =30;
    public int numberOfTiles=4;
    public Transform playerTransform;
    public List<GameObject> activeTiles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
     for (int i = 0; i < numberOfTiles; i++)
     {
        if(i==0){
            SpawnTile(0);
        }
        else
        SpawnTile(Random.Range(0, tilePrefabs.Length));
     /*   if(i==0)
        SpawnTile(0);   
        else
        SpawnTile(GameObject tilePrefabs = tilePrefabs[Random.Range(0, tilePrefabs.Length)]);*/
        
        
     }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z -35 > zSpawn - (numberOfTiles * tileLenght)){
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }

        
    }
    public void SpawnTile(int tileIndex){
       GameObject go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
       activeTiles.Add(go); 
        zSpawn += tileLenght;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}

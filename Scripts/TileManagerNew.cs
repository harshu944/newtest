using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManagerNew : MonoBehaviour
{

    public GameObject[] tilePrefabs;
    public GameObject[] planePrefabs;
    public float zSpawn = 0;
    public float tileLength = 20;
    public float PlaneLength = 20;
    public int numberOfTiles = 5;
    public int numberOfPlanes = 1;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
    private List<GameObject> activePlanes = new List<GameObject>();







    void Start()
    {
        for(int i=0;i<numberOfTiles;i++)
        {

            if (i == 0)
            {
                SpawnTile(0);

            }
            else
                SpawnTile(Random.Range(0, tilePrefabs.Length));
           

        }


    



for(int i=0;i<numberOfPlanes;i++)
        {

            if (i == 0)
            {

                SpawnPlane(0);
}
            else
    SpawnTile(Random.Range(0, planePrefabs.Length));
           

        }


    }







    void Update()
    {
        if (playerTransform.position.z-30 > zSpawn - (numberOfTiles * tileLength))
        {

            SpawnTile(Random.Range(0, tilePrefabs.Length));

            DeleteTile();
            SpawnPlane(Random.Range(0, planePrefabs.Length));

            
            DeletePlane();
        }
    }

    public void SpawnTile(int tileIndex)
    {
        GameObject go=Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
    }

    public void SpawnPlane(int planeIndex)
    {
        GameObject goo = Instantiate(planePrefabs[planeIndex], transform.forward * zSpawn, transform.rotation);
        activePlanes.Add(goo);
        zSpawn += PlaneLength;
    }


    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }




    private void DeletePlane()
    {
        Destroy(activePlanes[0]);
        activePlanes.RemoveAt(0);
    }
}

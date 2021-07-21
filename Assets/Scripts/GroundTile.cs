using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;

    [SerializeField] private GameObject coinPrefab;

    GroundSpawnManager groundSpawnManager;
    private float timeToDestroyTile = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        groundSpawnManager = GameObject.FindObjectOfType<GroundSpawnManager>();
    }

    void OnTriggerExit(Collider other)
    {
        groundSpawnManager.SpawnTile(true);
        Destroy(gameObject, timeToDestroyTile);
    }


    public void SpawnObstacle()
    {
        //get random index for spawning obstacle
        int obstacleSpawnPoint = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnPoint).transform;

        //spawn obstacle
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }


    public void SpawnCoins()
    {
        int noOfCoins = 5;
        for(int i = 0; i < noOfCoins; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
        );

        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }

}

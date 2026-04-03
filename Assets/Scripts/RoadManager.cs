using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] roadSegments;
    public GameObject[] obstacles;
    public float roadLength = 20f;
    public Transform player;

    void Update()
    {
        foreach (GameObject road in roadSegments)
        {
            if (road.transform.position.z < player.position.z - roadLength)
            {
                RecycleRoad(road);
            }
        }

        // Recycle obstacles that are behind the player
        foreach (GameObject obstacle in obstacles)
        {
            if (obstacle.transform.position.z < player.position.z - roadLength)
            {
                RepositionObstacle(obstacle);
            }
        }
    }

    void RecycleRoad(GameObject road)
    {
        float maxZ = 0;
        foreach (GameObject r in roadSegments)
        {
            if (r.transform.position.z > maxZ)
                maxZ = r.transform.position.z;
        }

        road.transform.position = new Vector3(
            road.transform.position.x,
            road.transform.position.y,
            maxZ + roadLength
        );
    }

    void RepositionObstacle(GameObject obstacle)
    {
        // Find the furthest road position
        float maxZ = 0;
        foreach (GameObject r in roadSegments)
        {
            if (r.transform.position.z > maxZ)
                maxZ = r.transform.position.z;
        }

        obstacle.transform.position = new Vector3(
            Random.Range(-2f, 2f),
            obstacle.transform.position.y,
            maxZ + Random.Range(5f, 15f)
        );
    }
}
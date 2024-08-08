using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float initialTimeBetweenObstacles = 2f; // Initial time between spawns
    public float minimumTimeBetweenObstacles = 0.5f; // Minimum time interval
    public float difficultyIncreaseRate = 0.1f; // Rate at which the difficulty increases

    private float timeBetweenObstacles;
    private float obstacleTime;

    // Start is called before the first frame update
    void Start()
    {
        timeBetweenObstacles = initialTimeBetweenObstacles;
        obstacleTime = Time.time + timeBetweenObstacles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= obstacleTime)
        {
            SpawnObstacle();
            obstacleTime = Time.time + timeBetweenObstacles;
            DecreaseTimeBetweenObstacles();
        }
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void DecreaseTimeBetweenObstacles()
    {
        // Gradually decrease the time between obstacle spawns
        if (timeBetweenObstacles > minimumTimeBetweenObstacles)
        {
            timeBetweenObstacles -= difficultyIncreaseRate * Time.deltaTime;
            timeBetweenObstacles = Mathf.Max(timeBetweenObstacles, minimumTimeBetweenObstacles); // Clamp to minimum
        }
    }
}

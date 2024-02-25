using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour
{
    public GameObject[] balloons;
    float x1 = 8f, x2 = 14.5f, y1 = 0f, y2 = 2.5f, z1 = 10.5f, z2 = 16.5f;

    void Start() // Changed from Update to Start
    {
        StartCoroutine(BalloonSpawner());
    }

    IEnumerator BalloonSpawner()
    {
        while (true) // Add an infinite loop to handle repeated spawning
        {
            yield return new WaitForSeconds(0.5f); // 
            Spawner();
        }
        // Removed the recursive call to BalloonSpawner()
    }

    void Spawner()
    {
        Vector3 randomPosition = new Vector3(Random.Range(x1, x2), Random.Range(y1, y2), Random.Range(z1, z2));
        int randomBal = Random.Range(0, balloons.Length);
        var Clone = Instantiate(balloons[randomBal], randomPosition, Quaternion.identity);
        Destroy(Clone, 2f); // Optionally adjust or remove the auto-destroy if it's not needed
    }
}

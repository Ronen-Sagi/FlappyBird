using UnityEngine;

public class pipeSpawnScript : MonoBehaviour
{
    public GameObject pipes;
    public float spawnRate;
    public float heightOffSet;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        float randomY = Random.Range(lowestPoint, highestPoint);
        Instantiate(pipes, new Vector3(transform.position.x, randomY), transform.rotation);
    }
}

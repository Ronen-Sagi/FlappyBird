using UnityEngine;

public class pipescript : MonoBehaviour
{
    public float moveSpeed;
    public float deadZoneX = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (transform.position.x < deadZoneX)
        {
            Destroy(gameObject);
        }
    }
}

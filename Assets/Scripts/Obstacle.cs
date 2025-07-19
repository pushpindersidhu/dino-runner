using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float velocity = -5f;
    public float deadZone = -10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deadZone)
            Destroy(gameObject);

        transform.position += new Vector3(velocity * Time.deltaTime, 0);
    }
}

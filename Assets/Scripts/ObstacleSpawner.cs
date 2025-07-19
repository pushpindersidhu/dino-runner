using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public BoxCollider2D ground;
    private float spawnRate = 2;

    private float timer = 0;

    void Start()
    {
        spawn();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        spawnRate = Random.Range(0.75f, 1.75f);
        spawn();
    }

    private void spawn()
    {
        var scale = Random.Range(0.75f, 1.25f);

        GameObject obj = Instantiate(obstacle, transform.position, transform.rotation);
        obj.transform.localScale = new Vector3(
                obj.transform.localScale.x,
                obj.transform.localScale.y * scale,
                obj.transform.localScale.z
            );

        SpriteRenderer sprite = obj.GetComponent<SpriteRenderer>();
        float offset = sprite.bounds.min.y - obj.transform.position.y;
        obj.transform.position += new Vector3(0, -offset, 0);
    }
}

using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    private float spriteWidth;

    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        spriteWidth = sprite.texture.width / sprite.pixelsPerUnit;
    }

    void Update()
    {
        float delta = -speed * Time.deltaTime;
        transform.position += new Vector3(delta, 0, 0);

        if ((Mathf.Abs(transform.position.x) - spriteWidth) > 0)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }
}

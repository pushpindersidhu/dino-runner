using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int jumpVelocity;
    public LogicManager lm;

    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;
    private bool isAlive = true;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        lm = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if (!isAlive) return;

        if (Keyboard.current.spaceKey.isPressed && grounded)
            Jump();

        anim.SetBool("grounded", grounded);
    }

    private void Jump()
    {
        body.linearVelocityY = jumpVelocity;
        grounded = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;

        else if (collision.gameObject.tag == "Obstacle")
        {
            isAlive = false;
            lm.GameOver();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float xMove;
    private float moveSpeed = 6;
    // public float bulletSpeed = 200;
    //public float autofireDelay = 0.001f;
    private bool fire = true;
    //public GameObject PlayerCannon;
    private Vector2 playerMovement;
    private bool BulletScript;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        UnityEngine.Debug.Log("Player position: " + transform.position);

    }

    // Update is called once per frame

    void Update()
    {
        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            BulletScript = fire;
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(playerMovement, ForceMode2D.Force);
        rb.velocity = playerMovement;
        xMove = (moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.CompareTag("Walls"))
        {
           // moveSpeed = xMove;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}



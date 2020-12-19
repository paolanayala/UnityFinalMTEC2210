using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float xMove;
    private float moveSpeed = 50;
    // public float bulletSpeed = 200;
    private bool fire = true;
    public GameObject PlayerBullet;
    private Vector2 playerMovement;
    private bool BulletScript;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

    void Update()
    {
        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(PlayerBullet, transform.position, Quaternion.identity);

            PlaySound.Instance.PlayOneShot
                (PlaySound.Instance.shoot);
        }
    }

    private void FixedUpdate()
    {
        xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        /*rb.AddForce(playerMovement, ForceMode2D.Force);
        rb.velocity = playerMovement;
        xMove = moveSpeed * Time.deltaTime;*/
    }

    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.CompareTag("Ground"))
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

}



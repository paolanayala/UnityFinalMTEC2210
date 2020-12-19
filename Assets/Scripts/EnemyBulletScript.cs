using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    public bool enemyBullet;
    public GameObject PlayerCannon;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(enemyBullet)
        {
            rb.velocity = (Vector2.down * speed * Time.deltaTime);
        }
        else
        {
            rb.velocity = (Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }

   private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform UFO;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float enemySpeed;
    private bool enemyMovement = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        float speedModifier = 1;
        float adjustedSpeed = enemySpeed + speedModifier;

        transform.position += (Vector3.left * adjustedSpeed * Time.deltaTime);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Walls")
        {
            transform.Translate(-Vector2.right * enemySpeed * Time.deltaTime);
        }

        if (transform.position.x <= 2.0f)
        {
            transform.Translate(Vector2.right * enemySpeed * Time.deltaTime);
        }
    }
}




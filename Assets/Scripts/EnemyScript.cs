using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private Transform UFO;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float enemySpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
       /* float speedModifier = 0;
        float adjustedSpeed = enemySpeed + speedModifier;

        transform.position += (Vector3.right * adjustedSpeed * Time.deltaTime);
       */

    }



}
